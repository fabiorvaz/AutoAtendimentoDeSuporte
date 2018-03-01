using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteSolution.Telas.LibreOffice
{
    public partial class LibreOffice : Form
    {
        public LibreOffice()
        {
            InitializeComponent();
        }

        private void btnRestauraLixeira_Click(object sender, EventArgs e)
        {
            SplashScreenAplicando janela = new SplashScreenAplicando();
            janela.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            janela.ShowDialog();
            MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Lib.LibreOffice.LibreOffice.matarProcessos();
        }
    }
}
