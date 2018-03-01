using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace SuporteSolution.Lib.Sistema
{
	static class Wsus
	{
		static public void HabilitarWsus()
		{
			ParrarServico();
						
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUServer", "http://sthor.intranet:8530");
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUStatusServer", "http://sthor.intranet:8530");

			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", 00000000);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions", 00000004);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "ScheduledInstallDay", 00000000);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "ScheduledInstallTime", 00000011);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "UseWUServer", 00000001);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers", 00000001);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "DetectuonFrequencyEnabled", 00000001);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "DetectionFrequency", 00000001);
			Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AutoInstallMinorUpdates", 00000001);

			IniciarServico();
		}

		static private void ParrarServico()
		{
			ServiceController sc = new ServiceController("wuauserv");

			if (sc.Status == ServiceControllerStatus.Running) sc.Stop();
			while (sc.Status == ServiceControllerStatus.StopPending) ;
		}

		static private void IniciarServico()
		{
			ServiceController sc = new ServiceController("wuauserv");

			if (sc.Status == ServiceControllerStatus.Stopped) sc.Start();
			while (sc.Status == ServiceControllerStatus.StartPending) ;
		}

		static public void DesabilitarWsus()
		{
			ParrarServico();

			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUServer");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "WUStatusServer");

			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "ScheduledInstallDay");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "ScheduledInstallTime");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "UseWUServer");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "DetectuinFrequencyEnabled");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "DetectionFrequency");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AutoInstallMinorUpdates");

			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "AccountDomainSid");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "PingID");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "SusClientId");

			IniciarServico();
		}

		static private void DeletarRegistro(string keyName, string keyValue)
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
			{
				if (key == null)
				{
					// Key doesn't exist. Do whatever you want to handle
					// this case
				}
				else
				{
					key.DeleteValue(keyValue);
				}
			}
		}

		static public void ReconfigurarWsus()
		{
			ParrarServico();

			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "AccountDomainSid");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "PingID");
			DeletarRegistro(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate", "SusClientId");

			IniciarServico();

			Process.Start(@"C:\Windows\system32\wuauclt /resetauthorization");
			Process.Start(@"C:\Windows\system32\wuauclt /detectnow");
			Process.Start(@"C:\Windows\system32\wuauclt /reportnow");
		}

		static public void LimparCache()
		{
			LimparPasta(@"C:\Windows\SoftwareDistribution\Download");
		}

		static private void LimparPasta(string caminho)
		{
			foreach (string pasta in Directory.GetDirectories(caminho))
			{
				LimparPasta(caminho);
				Directory.Delete(pasta);
			}
			foreach (string arquivo in Directory.GetFiles(caminho))
			{
				File.Delete(arquivo);
			}
		}
	}
}
