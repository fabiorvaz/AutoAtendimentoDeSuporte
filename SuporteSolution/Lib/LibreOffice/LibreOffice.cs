using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuporteSolution.Lib.LibreOffice
{
    static class LibreOffice
    {
        #region Funções Publicas

        static public void matarProcessos()
        {
            derrubarLibreoffice();
        }

        #endregion

        #region Funções Privadas

        /// <summary>
        /// Mata o processo do thunderbird.
        /// </summary>
        static private void derrubarLibreoffice()
        {
            foreach (Process process in Process.GetProcesses())
            {
                string nome = process.ProcessName.ToLower();
                if((nome.Contains("libreoffice"))
                    || (nome.Contains("soffice")))
                    process.Kill();
            }
        }

        #endregion

    }
}
