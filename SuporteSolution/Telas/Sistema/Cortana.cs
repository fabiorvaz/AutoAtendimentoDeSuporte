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
	public partial class Cortana : Form
	{
		public Cortana()
		{
			InitializeComponent();
		}

		private void btnAtivar_Click(object sender, EventArgs e)
		{
			SplashScreenAplicando janela = new SplashScreenAplicando();
			janela.backgroundWorker1.DoWork += backgroundWorker1DoWorkAtivar;
			janela.ShowDialog();
			MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnDesativar_Click(object sender, EventArgs e)
		{
			SplashScreenAplicando janela = new SplashScreenAplicando();
			janela.backgroundWorker1.DoWork += backgroundWorker1DoWorkDesativar;
			janela.ShowDialog();
			MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void backgroundWorker1DoWorkAtivar(object sender, DoWorkEventArgs e)
		{
			Lib.Sistema.Cortana.HabilitarCortana();
		}

		private void backgroundWorker1DoWorkDesativar(object sender, DoWorkEventArgs e)
		{
			Lib.Sistema.Cortana.DesabilitarCortana();
		}
	}
}
