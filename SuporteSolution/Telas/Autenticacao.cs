using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace SuporteSolution.Telas
{
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            if (Marshal.PtrToStringBSTR(Marshal.SecureStringToBSTR(Lib.Configuracoes.Senha)).Equals(txtSenha.Text))
            {
                Lib.Configuracoes.Autenticado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtSenha.Focus();
            }
        }

		private void Autenticacao_Load(object sender, EventArgs e)
		{
			labelVersao.Text = "Versão " + Application.ProductVersion;
		}
	}
}
