using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SuporteSolution.Telas.Impressora
{
    public partial class Impressora : Form
    {
        public Impressora()
        {
            InitializeComponent();
        }

        private void btnCopairDados_Click(object sender, EventArgs e)
        {
            SplashScreenAplicando janela = new SplashScreenAplicando();
            janela.backgroundWorker1.DoWork += limpaFilaImpressora_DoWork;
            janela.ShowDialog();
            MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpaFilaImpressora_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1500);
            Lib.Impressora.Impressora.LimparFila();
        }
    }
}
