using SuporteSolution.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuporteSolution.Lib.Thunderbird
{
    static class Thunderbird
    {
        #region Funções Publicas

        /// <summary>
        /// Restaura a lixeira do thunderbird quando a mesma fica corrompida ou some da lista de pastas.
        /// </summary>
        static public void restaurarLixeira()
        {
            derrubarThunderbird();
            List<string> contasThunderbird = localizarPastasDasContas();
            foreach (string pasta in contasThunderbird)
            {
                removerLixeira(pasta);
                recriarLixeira(pasta);
            }
        }

        #endregion

        #region Funções Privadas

        /// <summary>
        /// Localiza todas as pastas de contas, de todos os perfis existentes, do thunderbird.
        /// AVISO: Função não funciona caso a pasta do thunderbird não esteja em %appdata%
        /// </summary>
        /// <returns></returns>
        static private List<string> localizarPastasDasContas()
        {
            List<string> retorno = new List<string>();

            foreach (string profile in Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Thunderbird", "Profiles")))
            {
                foreach (string pasta in Directory.GetDirectories(profile))
                {
                    if ((pasta.ToLower().Contains("mail")) && (!pasta.ToLower().Contains("imap")))
                    {
                        foreach (string conta in Directory.GetDirectories(pasta))
                        {
                            retorno.Add(conta);
                        }
                    }
                }
            }


            return retorno;
        }

        /// <summary>
        /// Remove lixeira, não afeta subpastas da lixeira.
        /// </summary>
        /// <param name="pasta">endereço da pasta com os dados da conta de e-mail</param>
        static private void removerLixeira(string pasta)
        {
            foreach (string arquivo in Directory.GetFiles(pasta))
            {
                if (Path.GetFileName(arquivo).ToLower().Contains("trash"))
                {
                    File.Delete(arquivo);
                }
            }
        }

        /// <summary>
        /// Recria os arquivos da lixeira, usando arquivos vaizius, não afeta subpastas da lixeira.
        /// </summary>
        /// <param name="pasta">endereço da pasta com os dados da conta de e-mail</param>
        static private void recriarLixeira(string pasta)
        {
            File.WriteAllBytes(Path.Combine(pasta, "Trash"), Resources.Trash);
            File.WriteAllBytes(Path.Combine(pasta, "Trash.msf"), Resources.TrashMsf);
        }

        /// <summary>
        /// Mata o processo do thunderbird.
        /// </summary>
        static private void derrubarThunderbird()
        {
            foreach (var process in Process.GetProcessesByName("Thunderbird"))
            {
                process.Kill();
            }
        }

        #endregion


    }
}
