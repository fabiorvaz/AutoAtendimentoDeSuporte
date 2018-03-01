using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace SuporteSolution.Lib
{
    static class Configuracoes
    {

        #region Geral

        /// <summary>
        /// Define se um usuario foi autenticado no sistema
        /// </summary>
        public static bool Autenticado = false;
        private static SecureString senha = new SecureString();
        /// <summary>
        /// Senha de acesso da informatica
        /// </summary>
        public static SecureString Senha { 
            get 
            {
                senha = new SecureString();
                senha.AppendChar('s');
                senha.AppendChar('e');
                senha.AppendChar('n');
                senha.AppendChar('h');
                senha.AppendChar('a');
                return senha;
            } 
        }

        /// <summary>
        /// Converte uma string normal para uma string segura, que não pode ser lida com um memory dump.
        /// </summary>
        /// <param name="strPassword">string a ser convertida</param>
        /// <returns>objeto secure string convertido</returns>
        public static SecureString ConvertToSecureString(string strPassword)
        {
            var secureStr = new SecureString();
            if (strPassword.Length > 0)
            {
                foreach (var c in strPassword.ToCharArray()) secureStr.AppendChar(c);
            }
            return secureStr;
        }

        /// <summary>
        /// Retorna true caso o aplicativo esteja rodando como administrador na maquina.
        /// </summary>
        public static bool IsElevated
        {
            get
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private static void ElevateRights()
        {
            var exeName = Application.ExecutablePath;
            ProcessStartInfo startInfo = new ProcessStartInfo(exeName);

			// Passa adiante o flag de Autenticado
			if (Lib.Configuracoes.Autenticado)
				startInfo.Arguments += " --power";

            startInfo.Verb = "runas";
            System.Diagnostics.Process.Start(startInfo);
            System.Windows.Forms.Application.Exit();
            
            return;
		}

		/// <summary>
		/// Tenta rodar com direitos de administrador. Mostra uma mensagem caso não seja possível.
		/// </summary>
		/// <returns>Retorna true/false se conseguiu.</returns>
		public static bool TryElevateRights()
		{
			try
			{
				ElevateRights();
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(String.Format(
					"Não foi possível rodar o programa com permissões de administrador.\nErro: {0}-{1}",
					ex.GetType().Name,
					ex.Message), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

        #endregion

        #region Disco

        #region Copiar Dados

        /// <summary>
        /// Lista de textos a conter em pastas que o programa deve copiar ao transferir dados de um disco para outro
        /// </summary>
        public static List<string> TextoDePastasACopiar
        {
            get 
            {
                List<string> pastas = new List<string>();
                pastas.Add("document");
                pastas.Add("desktop");
                pastas.Add("trabalho");
                pastas.Add("imag");
                pastas.Add("music");
                pastas.Add("dados");
                pastas.Add("app");
                return pastas;
            }
        }

        /// <summary>
        /// Endereço de pastas que terão seu conteudo copiados, contanto que existam
        /// Importante: Não adicionar a letra do disco.
        /// </summary>
        public static List<string> PastasACopiarSempre
        {
            get
            {
                List<string> pastas = new List<string>();
                pastas.Add("temp");
                return pastas;
            }
        }

        /// <summary>
        /// Nome das chaves do registro do windows que contem as pastas que devem ser copiadas
        /// </summary>
        public static List<string> NomeDeChavesDoRegistroComAsPastasACopiar
        {
            get
            {
                List<string> pastas = new List<string>();
                pastas.Add("Desktop");
                pastas.Add("Favorites");
                pastas.Add("Local AppData");
                pastas.Add("Personal");
                return pastas;
            }
        }


        #endregion

        #region Excluir Dados

        /// <summary>
        /// Lista de textos a conter em pastas que o programa deve excluir
        /// </summary>
        public static List<string> TextoDePastasAExcluir
        {
            get
            {
                List<string> pastas = new List<string>();
                pastas.Add("document");
                pastas.Add("desktop");
                pastas.Add("trabalho");
                pastas.Add("imag");
                pastas.Add("music");
                pastas.Add("dados");
                pastas.Add("app");
                return pastas;
            }
        }

        /// <summary>
        /// Endereço de pastas que serão excluidas, contanto que existam
        /// Importante: Não adicionar a letra do disco.
        /// </summary>
        public static List<string> PastasAExcluirSempre
        {
            get
            {
                List<string> pastas = new List<string>();
                return pastas;
            }
        }

        /// <summary>
        /// Endereço de pastas que terão seu conteudo excluidos, contanto que existam
        /// Importante: Não adicionar a letra do disco.
        /// </summary>
        public static List<string> PastasAExcluirOConteudoSempre
        {
            get
            {
                List<string> pastas = new List<string>();
                pastas.Add("temp");
                return pastas;
            }
        }

        /// <summary>
        /// Nome das chaves do registro do windows que contem as pastas que devem ser excluidas
        /// </summary>
        public static List<string> NomeDeChavesDoRegistroComAsPastasAExcluir
        {
            get
            {
                List<string> pastas = new List<string>();
                pastas.Add("Desktop");
                pastas.Add("Favorites");
                pastas.Add("Local AppData");
                pastas.Add("Personal");
                return pastas;
            }
        }


        #endregion

        #endregion

    }
}
