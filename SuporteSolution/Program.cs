using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteSolution
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (ProcessExecutablePath(args))
				return;

			ProcessCommandLine(args);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Telas.Principal());
		}

		private static bool ProcessExecutablePath(string[] args)
		{
			// Se o programa for executado com a versão velha, tenta abrir com a versão nova
			if (Application.ExecutablePath.ToLower().StartsWith(@"\\sntolvebra\autoupd\instaladores\suportesolution\"))
			{
				string canonicPath = @"\\sntolvebra\autoupd\Dinfo\SuporteSolution.exe";
				var psi = new ProcessStartInfo(canonicPath);
				psi.Arguments = String.Join(" ", args);
				psi.UseShellExecute = false;
				try
				{
					using (var p = Process.Start(psi))
					{
						// Abriu com sucesso a versão certa, então fecha a versão atual
						return true;
					}
				}
				catch (Exception)
				{
					// Ignora o erro e abre normalmente
				}
			}
			return false;
		}

		private static void ProcessCommandLine(string[] args)
		{
			foreach (var param in args)
			{
				if (param.StartsWith("-"))
				{
					switch (param)
					{
						case "--power":
							Lib.Configuracoes.Autenticado = true;
							break;
					}
				}
			}
		}
	}
}
