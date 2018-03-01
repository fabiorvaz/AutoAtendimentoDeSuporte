using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteSolution.Telas
{
    public partial class SplashScreenAplicando : Form
    {
        public List<object> arguments = new List<object>();
        public SplashScreenAplicando()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void SplashScreenAplicando_Shown(object sender, EventArgs e)
        {
            if(arguments.Count>0)
                backgroundWorker1.RunWorkerAsync(arguments);
            else
                backgroundWorker1.RunWorkerAsync();
        }
    }
}
