using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuporteSolution.Lib.Sistema
{
	static class Cortana
	{
		static private string chaveCortana = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search";
		static private string valorCortana = @"AllowCortana";

		static public void HabilitarCortana()
		{
				Registry.SetValue(chaveCortana, valorCortana, 1);
		}

		static public void DesabilitarCortana()
		{
				Registry.SetValue(chaveCortana, valorCortana, 0);
		}
	}
}
