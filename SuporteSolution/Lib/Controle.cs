using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuporteSolution.Lib
{
	static class Controle
	{
		static public void ReiniciarComputador()
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "shutdown /r /t 0 /f";
			process.StartInfo = startInfo;
			process.Start();
			process.WaitForExit();
		}

		/// <summary>
		/// Cria um arquivo de texto para
		/// </summary>
		/// <param name="conteudo">Código da ação a ser continuada (somente numero).
		/// 1-Ativar WSUS limpando a fila de updates;
		/// 2-Limpar a fila de updates;</param>
		static public void CriarArquivoDeContinuidade(string conteudo)
		{
			System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt");
			file.WriteLine(conteudo);

			file.Close();
		}

		static public void ContinuarTarefa()
		{ }

		static private void LerArquivoDeContinuidade()
		{
			int counter = 0;
			string line;

			System.IO.StreamReader file =
			new System.IO.StreamReader(Properties.Settings.Default.ArquivoDeContinuidade);
			while ((line = file.ReadLine()) != null)
			{
				switch (line)
				{
					case "1":
						// 1-Ativar WSUS limpando a fila de updates;
						if (Lib.Configuracoes.IsElevated)
						{
							Lib.Sistema.Wsus.HabilitarWsus();
						}
						else
						{
							Lib.Configuracoes.TryElevateRights();
						}
						break;
					case "2":
						// 2-Limpar a fila de updates;
						if (Lib.Configuracoes.IsElevated)
						{
						}
						else
						{
							Lib.Configuracoes.TryElevateRights();
						}
						break;
					default:
						break;
				}
				counter++;
			}

			file.Close();
		}

		static private void ApagarArquivoDeContinuidade()
		{
			if (System.IO.File.Exists(Properties.Settings.Default.ArquivoDeContinuidade)) ;
			{
				System.IO.File.Delete(Properties.Settings.Default.ArquivoDeContinuidade);
			}
		}

		static private void CriarAtalhoDeContinuidade()
		{
			object shDesktop = (object)"Desktop";
			WshShell shell = new WshShell();
			string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\suporte.lnk";
			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
			shortcut.TargetPath = @"\\sntolvebra\Autoupd\Instaladores\SuporteSolution\SuporteSolution.exe";
			shortcut.Save();
		}

		static private void ApagarAtalhoDeContinuidade()
		{
			if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\suporte.lnk")) ;
			{
				System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\suporte.lnk");
			}
		}
	}
}
