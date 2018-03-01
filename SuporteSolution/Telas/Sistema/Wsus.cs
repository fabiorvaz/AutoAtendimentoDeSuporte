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
	public partial class Wsus : Form
	{
		public Wsus()
		{
			InitializeComponent();
		}

		private void btnAtivar_Click(object sender, EventArgs e)
		{
			SplashScreenAplicando janela = new SplashScreenAplicando();
			janela.backgroundWorker1.DoWork += backgroundWorker1DoWorkAtivar;
			janela.ShowDialog();
			//MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (MessageBox.Show("É nescessario reiniciar o computador para concluir o procedimento. \r\nDeseja fazer isso agora?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Lib.Controle.ReiniciarComputador();
			}
		}

		private void btnDesativar_Click(object sender, EventArgs e)
		{
			SplashScreenAplicando janela = new SplashScreenAplicando();
			janela.backgroundWorker1.DoWork += backgroundWorker1DoWorkDesativar;
			janela.ShowDialog();
			if (MessageBox.Show("É nescessario reiniciar o computador para concluir o procedimento. \r\nDeseja fazer isso agora?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Lib.Controle.ReiniciarComputador();
			}
		}

		private void btnReconfigurar_Click(object sender, EventArgs e)
		{
			SplashScreenAplicando janela = new SplashScreenAplicando();
			janela.backgroundWorker1.DoWork += backgroundWorker1DoWorkReconfigurar;
			janela.ShowDialog();
			if (MessageBox.Show("É nescessario reiniciar o computador para concluir o procedimento. \r\nDeseja fazer isso agora?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				Lib.Controle.ReiniciarComputador();
			}
		}

		private void backgroundWorker1DoWorkAtivar(object sender, DoWorkEventArgs e)
		{
			Lib.Sistema.Wsus.HabilitarWsus();
		}

		private void backgroundWorker1DoWorkDesativar(object sender, DoWorkEventArgs e)
		{
			Lib.Sistema.Wsus.DesabilitarWsus();
		}

		private void backgroundWorker1DoWorkReconfigurar(object sender, DoWorkEventArgs e)
		{
			Lib.Sistema.Wsus.ReconfigurarWsus();
		}

	}
}
