using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuporteSolution.Telas.Sistema
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void btnInstalarProgramasPadrao_Click(object sender, EventArgs e)
        {
            if (Lib.Configuracoes.IsElevated)
            {
                SplashScreenAplicando janela = new SplashScreenAplicando();
                janela.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
                janela.ShowDialog();
                MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Lib.Configuracoes.TryElevateRights();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Lib.Sistema.InstalarProgramasPadrao.Instalar();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
			if (Lib.Configuracoes.IsElevated)
				this.Text += " (Admin)";
		}

		private void btnCortana_Click(object sender, EventArgs e)
		{
			if (Lib.Configuracoes.IsElevated)
			{
				Cortana janela = new Cortana();
				janela.ShowDialog();
			}
			else
			{
				Lib.Configuracoes.TryElevateRights();
			}
		}

		private void btnOneDrive_Click(object sender, EventArgs e)
		{
			if (Lib.Configuracoes.IsElevated)
			{
				OneDrive janela = new OneDrive();
				janela.ShowDialog();
			}
			else
			{
				Lib.Configuracoes.TryElevateRights();
			}
		}

		private void btnWsus_Click(object sender, EventArgs e)
		{
			if (Lib.Configuracoes.IsElevated)
			{
				Wsus janela = new Wsus();
				janela.ShowDialog();
			}
			else
			{
				Lib.Configuracoes.TryElevateRights();
			}
		}
	}
}
