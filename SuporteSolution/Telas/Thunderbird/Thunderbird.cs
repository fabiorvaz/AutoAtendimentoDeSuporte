using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteSolution.Telas.Thunderbird
{
    public partial class Thunderbird : Form
    {
        public Thunderbird()
        {
            InitializeComponent();
        }

        private void btnRestauraLixeira_Click(object sender, EventArgs e)
        {
            SplashScreenAplicando janela = new SplashScreenAplicando();
            janela.backgroundWorker1.DoWork +=backgroundWorker1_DoWork;
            janela.ShowDialog();
            MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1500);
            Lib.Thunderbird.Thunderbird.restaurarLixeira();
        }

        private void btnGerarAssinatura_Click(object sender, EventArgs e)
        {
            CriarAssinatura janela = new CriarAssinatura();
            janela.ShowDialog();
        }

        private void Thunderbird_Load(object sender, EventArgs e)
        {
            if (Lib.Configuracoes.Autenticado)
            {
                btnGerarAssinatura.Visible = true;
            }
        }
    }
}
