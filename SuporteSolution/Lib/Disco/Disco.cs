using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SuporteSolution.Lib.Disco
{
    class Disco
    {
        
        #region Singleton

        private static readonly Disco instancia = new Disco();
        private Disco() { }

        public static Disco Default
           {
               get
               {
                   return instancia;
               }
           }

        #endregion

        public Dictionary<string, string> ListaDiscos { get { GetDiscos(); return listaDiscos; } }

        private Dictionary<string, string> listaDiscos = new Dictionary<string, string>(); 

        private void GetDiscos()
        {
            listaDiscos.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                try
                {
                    listaDiscos.Add(drive.Name, (drive.VolumeLabel + " (" + drive.Name + ")"));
                }
                catch (Exception ex)
                { }
            }
        }
    }

 
}
