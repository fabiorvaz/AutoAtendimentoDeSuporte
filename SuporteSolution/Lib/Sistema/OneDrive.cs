using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SuporteSolution.Lib.Sistema
{
	static class OneDrive
	{
		static private string chaveOneDrive = @"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\OneDrive";
		static private string valorOneDrive = @"DisableFileSyncNGSC";

		static public void HabilitarOneDrive()
		{
			Registry.SetValue(chaveOneDrive, valorOneDrive, 0);
		}

		static public void DesabilitarOneDrive()
		{
			Registry.SetValue(chaveOneDrive, valorOneDrive, 1);
		}

		static public void DesinstalarOneDrive()
		{
			string caminho;
			if (Environment.Is64BitOperatingSystem)
			{
				caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "SysWOW64", "OneDriveSetup.exe");
			}
			else
			{
				caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "System32", "OneDriveSetup.exe");
			}
			if (File.Exists(caminho))
			{
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				startInfo.FileName = caminho;
				startInfo.Arguments = "/uninstall";
				process.StartInfo = startInfo;
				process.Start();
				process.WaitForExit();
			}
		}
	}
}
