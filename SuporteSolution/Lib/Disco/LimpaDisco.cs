using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SuporteSolution.Lib.Disco
{
    static class LimpaDisco
    {

        #region Variaveis

        /// <summary>
        /// Lista de pastas que o programa não teve acesso para analisar
        /// </summary>
        static private List<string> pastasSemAcesso = new List<string>();
        /// <summary>
        /// Lista de arquivos a serem copiados
        /// </summary>
        static private List<string> arquivosAExcluir = new List<string>();
        /// <summary>
        /// Nome do arquivo de log, usado somente na depuração
        /// </summary>
        static string ARQUIVOLOG = "logArquivos.txt";
        

        #endregion


        static public void LimparDadosViaRegistro(string origem)
        {

            #region variaveis

            string usuarioOrigem = EncontraPastaDoUsuario(origem);
            
            RegistryKey current = Registry.CurrentUser.OpenSubKey("Volatile Environment");
            string pastaUsuarioAtual = current.GetValue("userprofile").ToString();
            current.Close();

            Dictionary<string, string> pastasAExcluirRegistroOrigem = new Dictionary<string, string>();

            #endregion
            
            pastasAExcluirRegistroOrigem = LocalizarPastasRegistro(origem, usuarioOrigem, true);

            if (pastaUsuarioAtual == usuarioOrigem)
                pastasAExcluirRegistroOrigem = LocalizarPastasRegistro(origem, usuarioOrigem, false);
            else
                pastasAExcluirRegistroOrigem = LocalizarPastasRegistro(origem, usuarioOrigem, true);


            ExcluirOsDadosListaDePastas(origem, pastasAExcluirRegistroOrigem);
        }
        
        static private string EncontraPastaDoUsuario(string disco)
        {
            string pastaUsuario = "";
            string pastaUsuariosSistema = "";

            foreach (string caminho in Directory.GetDirectories(disco))
            {
                if (caminho.ToLower().Contains("documents"))
                    pastaUsuariosSistema = caminho;
                if (caminho.ToLower().Contains("users"))
                    pastaUsuariosSistema = caminho;
                if (caminho.ToLower().Contains("usuarios"))
                    pastaUsuariosSistema = caminho;
            }

            List<string> usuarios = new List<string>();
            foreach (string caminho in Directory.GetDirectories(pastaUsuariosSistema))
            {
                if (
                    (!caminho.ToLower().Contains("all")) &&
                    (!caminho.ToLower().Contains("default"))
                    )
                {
                    usuarios.Add(caminho);
                }
            }

            if (usuarios.Count == 1)
                pastaUsuario = usuarios[1];
            else
            {
                string usuarioMaior = "";
                DateTime recente = DateTime.Now.AddYears(-5);
                foreach (string caminho in usuarios)
                {
                    try
                    {
                        DateTime dataTemp = new DirectoryInfo(caminho).LastWriteTime;
                        if (dataTemp > recente)
                        {
                            usuarioMaior = caminho;
                            recente = dataTemp;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                pastaUsuario = usuarioMaior;
            }

            return pastaUsuario;
        }

        private static Dictionary<string, string> LocalizarPastasRegistro(string origem, string usuarioOrigem, bool p)
        {
            const string currentUserPaths = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            if (p)
            {
                string wimHivePath = Path.Combine(usuarioOrigem, "ntuser.dat");
                string loadedHiveKey = RegistryInterop.Load(wimHivePath);
                const string regKeyFolders = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";

                RegistryKey rk = Registry.Users.OpenSubKey(loadedHiveKey);

                if (rk != null)
                {
                    string abc = regKeyFolders.Replace("<SID>", "Test");
                    RegistryKey srk = rk.OpenSubKey(regKeyFolders);
                    if (srk != null)
                    {
                        foreach (string nome in Lib.Configuracoes.NomeDeChavesDoRegistroComAsPastasAExcluir)
                        {
                            string valor = srk.GetValue(nome).ToString();
                            if (valor == "")
                            {
                            }
                            else
                            {
                                retorno.Add(nome, valor.Replace("C:\\", origem));
                            }
                        }
                    }
                    rk.Close();
                }
                RegistryInterop.Unload();
            }
            else
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(currentUserPaths);

                if (rk != null)
                {
                    foreach (string nome in Lib.Configuracoes.NomeDeChavesDoRegistroComAsPastasAExcluir)
                    {
                        string valor = rk.GetValue(nome).ToString();
                        if (valor == "")
                        {
                        }
                        else
                        {
                            retorno.Add(nome, valor.Replace("C:\\", origem));
                        }
                    }
                    rk.Close();
                }
            }
            return retorno;
        }
                
        private static void ExcluirOsDadosListaDePastas(string origem, Dictionary<string, string> pastasAExcluirRegistroOrigem)
        {
            arquivosAExcluir.Clear();
            foreach (string nome in pastasAExcluirRegistroOrigem.Keys)
            {
                LocalizarDadosDoUsuarioASeremEcluidos(pastasAExcluirRegistroOrigem[nome]);
            }
            ExcluirOsDados();
            arquivosAExcluir.Clear();
        }
        
        static private void LocalizarDadosDoUsuarioASeremEcluidos(string pasta)
        {
            try
            {
                foreach (string caminho in Directory.GetDirectories(pasta))
                {
                    foreach (string teste in Lib.Configuracoes.TextoDePastasAExcluir)
                    {
                        if (caminho.ToLower().Contains(teste))
                        {
                            LocalizarDadosDoUsuarioASeremEcluidos(caminho);
                            break;
                        }
                    }
                }

                if ((pasta.StartsWith(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))) && (!pasta.ToLower().Contains("bird")))
                    return;

                if ((pasta.ToLower().Contains("aplicativos")) && (!pasta.ToLower().Contains("bird")))
                    return;
                foreach (string caminho in Directory.GetFiles(pasta))
                {
                    arquivosAExcluir.Add(caminho);
                }
            }
            catch (Exception ex)
            {
            }
        }
        
        static private void ExcluirOsDados()
        {
            foreach (string caminho in arquivosAExcluir)
            {
                try
                {
                    File.Delete(caminho);
                    if (Directory.GetFiles(Path.GetDirectoryName(caminho)).Count() == 0)
                    {
                        //gravaLog(caminho);
                        Directory.Delete(Path.GetDirectoryName(caminho));
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        
        static private string EncontraPastaAppDataDoUsuario(string pastaDoUsuario)
        {
            string pastaApp = "";

            foreach (string caminho in Directory.GetDirectories(pastaDoUsuario))
            {
                if (caminho.ToLower().Contains("app"))
                    pastaApp = caminho;
                if (caminho.ToLower().Contains("aplica"))
                    pastaApp = caminho;
            }
            return pastaApp;
        }
        
        /// <summary>
        /// Grava uma mensagem em um arquivo de log
        /// </summary>
        /// <param name="texto">Mensagem a ser gravada</param>
        static private void gravaLog(string texto)
        {
            string PASTA = "c:\\temp\\logSuporte";
            List<string> mensagem = new List<string>();
            if ((!PASTA.Equals("")) && (!ARQUIVOLOG.Equals("")))
            {
                if (!Directory.Exists(PASTA))
                    Directory.CreateDirectory(PASTA);
                if (!File.Exists(Path.Combine(PASTA, ARQUIVOLOG)))
                {
                    FileStream f = File.Create(Path.Combine(PASTA, ARQUIVOLOG));
                    f.Close();
                }
            }
            using (StreamWriter file = new StreamWriter(Path.Combine(PASTA, ARQUIVOLOG), true))
            {
                file.WriteLine(texto);
            }
        }


    }
}
