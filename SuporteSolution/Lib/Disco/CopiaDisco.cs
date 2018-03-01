using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SuporteSolution.Lib.Disco
{
    static class CopiaDisco
    {
        #region Variaveis

        /// <summary>
        /// Lista de pastas que o programa não teve acesso para analisar
        /// </summary>
        static private List<string> pastasSemAcesso = new List<string>();
        /// <summary>
        /// Lista de arquivos a serem copiados
        /// </summary>
        static private List<string> arquivosACopiar = new List<string>();
        /// <summary>
        /// Nome do arquivo de log, usado somente na depuração
        /// </summary>
        static string ARQUIVOLOG = "logArquivos.txt";

        /// <summary>
        /// Caminho da pasta de usuario no disco de origem, caso não preenchido o script irá pesquisar a pasta automaticamente.
        /// </summary>
        static public string pastaUsuarioAntigo = "";
        /// <summary>
        /// Caminho da pasta de usuario no disco de destino, caso não preenchido o script irá pesquisar a pasta automaticamente.
        /// </summary>
        static public string pastaUsuarioNovo = "";

        /// <summary>
        /// Caminho da pasta AppData no disco de origem, caso não preenchido o script irá pesquisar a pasta automaticamente.
        /// </summary>
        static public string pastaAppAntigo = "";
        /// <summary>
        /// Caminho da pasta AppData no disco de origem, caso não preenchido o script irá pesquisar a pasta automaticamente.
        /// </summary>
        static public string pastaAppNovo = "";

        /// <summary>
        /// Caminho da pasta de dados do usuario no disco de origem, caso não preenchido o script irá pesquisar a pasta automaticamente.
        /// </summary>
        static public string pastaDadosAntigo = "";
        /// <summary>
        /// Caminho da pasta de dados de usuario no disco de destino, caso não preenchido o script manterá o nome da pasta que está no disco de origem
        /// </summary>
        static public string pastaDadosNovo = "";

        #endregion

        #region funções

        /// <summary>
        /// Copia os dados de um disco para o outro
        /// </summary>
        /// <param name="origem">Disco de origem dos dados</param>
        /// <param name="destino">Disco de destino dos dados</param>
        static public void CopiarDadosViaAutoBusca(string origem, string destino)
        {
            pastasSemAcesso = new List<string>();
            arquivosACopiar = new List<string>();
            LocalizarDadosASeremCopiados(origem);
            PassarOsDados(origem, destino);
        }

        /// <summary>
        /// Localiza todos os dados dentro da pasta especificada, entrando nas subpastas,
        /// Caso apontado a raiz do disco irá correr todo disco, após a execução dessa função a lista "pastasACopiar" estará preenchida
        /// </summary>
        /// <param name="origem">Pasta que deve ser analisada</param>
        static private void LocalizarDadosASeremCopiados(string origem)
        {
            if (pastaUsuarioAntigo == "")
                pastaUsuarioAntigo = EncontraPastaDoUsuario(origem);
            LocalizarDadosDoUsuarioASeremCopiados(pastaUsuarioAntigo);
            if (pastaDadosAntigo == "")
                LocalizarDadosDoUsuarioASeremCopiados(pastaDadosAntigo);
            foreach (string pasta in Lib.Configuracoes.PastasACopiarSempre)
                LocalizarDadosDoUsuarioASeremCopiados(Path.Combine(origem, pasta));
        }

        /// <summary>
        /// Percorre as pastas recursivamente analisando o nome da pasta ou arquivo para que possa ser transferido
        /// </summary>
        /// <param name="pasta">Caminho completo da pasta a ser analisada</param>
        static private void LocalizarDadosDoUsuarioASeremCopiados(string pasta)
        {
            try
            {
                foreach (string caminho in Directory.GetDirectories(pasta))
                {
                    foreach (string teste in Lib.Configuracoes.TextoDePastasACopiar)
                    {
                        if (caminho.ToLower().Contains(teste))
                        {
                            LocalizarDadosDoUsuarioASeremCopiados(caminho);
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
                    arquivosACopiar.Add(caminho);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Executa a cópia dos dados de um disco para o outro
        /// </summary>
        /// <param name="origem">disco de origem</param>
        /// <param name="destino">disco de destino</param>
        static private void PassarOsDados(string origem, string destino)
        {
            pastaUsuarioNovo = EncontraPastaDoUsuario(destino);
            if (pastaAppAntigo == "")
            {
                pastaAppAntigo = EncontraPastaAppDataDoUsuario(pastaUsuarioAntigo);
                pastaAppNovo = EncontraPastaAppDataDoUsuario(pastaUsuarioNovo);
            }
            foreach (string caminho in arquivosACopiar)
            {
                try
                {
                    string caminhoDestino = "";
                    if (caminho.StartsWith(pastaAppAntigo))
                    {
                        caminhoDestino = caminho.Replace(pastaAppAntigo, pastaAppNovo);
                    }
                    else if (caminho.StartsWith(pastaDadosAntigo))
                    {
                        caminhoDestino = caminho.Replace(pastaDadosAntigo, pastaDadosNovo);
                    }

                    else if (caminho.StartsWith(pastaUsuarioAntigo))
                    {
                        caminhoDestino = caminho.Replace(pastaUsuarioAntigo, pastaUsuarioNovo);
                    }
                    else
                    {
                        caminhoDestino = caminho.Replace(origem, destino);
                    }

                    if (!Directory.Exists(Path.GetDirectoryName(caminhoDestino)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(caminhoDestino));
                    }
                    File.Copy(caminho, caminhoDestino, true);

                }
                catch (Exception ex)
                {
                }
            }
        }

        /// <summary>
        /// Localiza a pasta do usario mais recentemente ativo no disco especificado
        /// </summary>
        /// <param name="disco">Disco a ser analisado</param>
        /// <returns>Caminho completo da pasta do usuario</returns>
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

        /// <summary>
        /// Analisa o caminho especificado e retorna a pasta AppData
        /// </summary>
        /// <param name="pastaDoUsuario">Caminho da pasta ser analisada</param>
        /// <returns>Caminho da pasta AppData</returns>
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

        static private void teste()
        {
            const string regKeyFolders = @"HKEY_USERS\<SID>\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";
            const string regValueAppData = @"Local AppData";
            string[] keys = Registry.Users.GetSubKeyNames();
            List<String> paths = new List<String>();

            foreach (string sid in keys)
            {
                string appDataPath = Registry.GetValue(regKeyFolders.Replace("<SID>", sid), regValueAppData, null) as string;
                if (appDataPath != null)
                {
                    paths.Add(appDataPath);
                }
            }
        }

        static public void CopiarDadosViaRegistro(string origem, string destino)
        {

            #region variaveis

            string usuarioOrigem = EncontraPastaDoUsuario(origem);
            string usuarioDestino = EncontraPastaDoUsuario(destino);

            const string currentUserPaths = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";
            const string currentUserHomePath = @"Volatile Environment\userprofile";
            
            RegistryKey current = Registry.CurrentUser.OpenSubKey("Volatile Environment");
            string pastaUsuarioAtual = current.GetValue("userprofile").ToString();
            current.Close();

            Dictionary<string, string> pastasACopiarRegistroOrigem = new Dictionary<string, string>();
            Dictionary<string, string> pastasACopiarRegistroDestino = new Dictionary<string, string>();

            #endregion

            if (pastaUsuarioAtual == usuarioDestino)
                pastasACopiarRegistroDestino = LocalizarPastasRegistro(origem, usuarioOrigem, true);
            else
                pastasACopiarRegistroDestino = LocalizarPastasRegistro(origem, usuarioOrigem, true);


            pastasACopiarRegistroOrigem = LocalizarPastasRegistro(origem, usuarioOrigem, true);

            if (pastaUsuarioAtual == usuarioOrigem)
                pastasACopiarRegistroOrigem = LocalizarPastasRegistro(origem, usuarioOrigem, false);
            else
                pastasACopiarRegistroOrigem = LocalizarPastasRegistro(origem, usuarioOrigem, true);


            PassarOsDadosListaDePastas(origem, destino, pastasACopiarRegistroOrigem, pastasACopiarRegistroDestino);

            
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
                        foreach (string nome in Configuracoes.NomeDeChavesDoRegistroComAsPastasACopiar)
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
                    foreach (string nome in Configuracoes.NomeDeChavesDoRegistroComAsPastasACopiar)
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
        
        /// <summary>
        /// Executa a passagem de dados através de uma lista de pasta.
        /// Nescessario a criação de dois dictonarys, contendo o identificador da pasta e o endereço dela, um dictionary para o disco de origem e outro para o de destino.
        /// </summary>
        /// <param name="origem">disco de origem</param>
        /// <param name="destino">disco de destino</param>
        /// <param name="pastasACopiarRegistroOrigem">lista de pastas dentro do disco de origem</param>
        /// <param name="pastasACopiarRegistroDestino">lista de pastas dentro do disco de destino</param>
        private static void PassarOsDadosListaDePastas(string origem, string destino, Dictionary<string, string> pastasACopiarRegistroOrigem, Dictionary<string, string> pastasACopiarRegistroDestino)
        {
            foreach (string nome in pastasACopiarRegistroOrigem.Keys)
            {
                arquivosACopiar.Clear();
                LocalizarDadosDoUsuarioASeremCopiados(pastasACopiarRegistroOrigem[nome]);
                foreach (string caminho in arquivosACopiar)
                {
                    string caminhoDestino = caminho.Replace(pastasACopiarRegistroOrigem[nome], pastasACopiarRegistroDestino[nome]); ;
                    File.Copy(caminho, caminhoDestino, true);
                }
            }

            arquivosACopiar.Clear();
            foreach (string pasta in Lib.Configuracoes.PastasACopiarSempre)
                LocalizarDadosDoUsuarioASeremCopiados(Path.Combine(origem, pasta));
            PassarOsDados(origem, destino);
        }
    }


        #endregion
}
