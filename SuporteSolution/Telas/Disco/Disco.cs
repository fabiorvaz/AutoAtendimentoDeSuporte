using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuporteSolution.Telas.Disco
{
    public partial class Disco : Form
    {
        public Disco()
        {
            InitializeComponent();
        }

        private void btnCopairDados_Click(object sender, EventArgs e)
        {
            CopiarDados janela = new CopiarDados();
            janela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparDisco janela = new LimparDisco();
            janela.ShowDialog();
        }

		private void Disco_Load(object sender, EventArgs e)
		{
			if (Lib.Configuracoes.IsElevated)
				this.Text += " (Admin)";
		}
	}
}
