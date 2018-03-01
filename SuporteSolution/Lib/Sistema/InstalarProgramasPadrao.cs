using SuporteSolution.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;

namespace SuporteSolution.Lib.Sistema
{
    static class InstalarProgramasPadrao
    {
        static public void Instalar()
        {
            InstalarChoco();
            InstalarProgramas();
        }

        static private void InstalarChoco()
        {
			if (!File.Exists("C:\\ProgramData\\chocolatey\\choco.exe"))
			{
				string pasta = "c:\\temp";
				if (!Directory.Exists(pasta)) Directory.CreateDirectory(pasta);

				string arquivo = Path.Combine(pasta, "installChocolatey.cmd");
				File.WriteAllText(arquivo, Resources.installChocolatey);

				string args = @"";
				ProcessStartInfo psi = new ProcessStartInfo();
				//psi.CreateNoWindow = true; //This hides the dos-style black window that the command prompt usually shows
				//psi.FileName = @"cmd.exe ";
				psi.FileName = arquivo;
				psi.Verb = "runas"; //this is what actually runs the command as administrator "/C " + 
				psi.UseShellExecute = true;
				//psi.Arguments = " /C \""+ arquivo + "\" " + args;
				try
				{
					var process = new Process();
					process.StartInfo = psi;
					process.Start();
					process.WaitForExit();

					DateTime inicio = DateTime.Now;

					while (!File.Exists("C:\\ProgramData\\chocolatey\\choco.exe"))
					{
						if ((DateTime.Now.Minute - inicio.Minute) > 15)
						{
							break;
						}
					}

					Thread.Sleep(5 * 1000);

					//if (File.Exists(arquivo)) File.Delete(arquivo);
					//if (File.Exists(Path.Combine(pasta, "install.ps1"))) File.Delete(Path.Combine(pasta, "install.ps1"));
					//if (File.Exists(Path.Combine(System.Windows.Forms.Application.StartupPath, "install.ps1"))) File.Delete(Path.Combine(System.Windows.Forms.Application.StartupPath, "install.ps1"));
				}
				catch (Exception)
				{
					//If you are here the user clicked declined to grant admin privileges (or he's not administrator)
				}
			}
        }

        static private void InstalarProgramas()
        {
			string nomeDoWindows = DescobrirVersaoDoWindows();

			if (nomeDoWindows.ToLower().Replace(" ", "").Contains("windows10"))
			{
				foreach (string packageName in Properties.Settings.Default.ListaDePacotesParaInstalarNoWindows10.Split(';'))
				{
					InstalarPrograma(packageName);
				}
				return;
			}

			if (nomeDoWindows.ToLower().Replace(" ", "").Contains("windows8"))
			{
				foreach (string packageName in Properties.Settings.Default.ListaDePacotesParaInstalarNoWindows8.Split(';'))
				{
					InstalarPrograma(packageName);
				}
				return;
			}

			if (nomeDoWindows.ToLower().Replace(" ", "").Contains("windows7"))
			{
				foreach (string packageName in Properties.Settings.Default.ListaDePacotesParaInstalarNoWindows7.Split(';'))
				{
					InstalarPrograma(packageName);
				}
				return;
			}

			if (nomeDoWindows.ToLower().Replace(" ", "").Contains("windowsvista"))
			{
				foreach (string packageName in Properties.Settings.Default.ListaDePacotesParaInstalarNoWindowsVista.Split(';'))
				{
					InstalarPrograma(packageName);
				}
				return;
			}

			if (nomeDoWindows.ToLower().Replace(" ", "").Contains("windowsxp"))
			{
				foreach (string packageName in Properties.Settings.Default.ListaDePacotesParaInstalarNoWindowsXp.Split(';'))
				{
					InstalarPrograma(packageName);
				}
				return;
			}
        }

		static private string DescobrirVersaoDoWindows()
		{
			var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
						select x.GetPropertyValue("Caption")).FirstOrDefault();
			return name != null ? name.ToString() : "Unknown";
		}

		static private void InstalarPrograma(string packageName)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			if (!Instalado(packageName))
				startInfo.Arguments = "/C choco install " + packageName + " -y -debug > c:\\temp\\" + packageName.Split(' ')[0] + "InstallLog.txt";
			else
				startInfo.Arguments = "/C choco upgrade " + packageName + " -y -debug > c:\\temp\\" + packageName.Split(' ')[0] + "InstallLog.txt";
			process.StartInfo = startInfo;
			process.Start();
			process.WaitForExit();
		}

		static private bool Instalado(string packageName)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.RedirectStandardOutput = true;
			startInfo.Arguments = "/C choco list -lo";
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;

			process.StartInfo = startInfo;
			process.Start();

			string output = process.StandardOutput.ReadToEnd();
			
			process.WaitForExit();
			
			foreach (string linha in output.Split('\r'))
			{
				if (linha.Contains(packageName)) return true;
			}

			return false;
		}
    }
}
