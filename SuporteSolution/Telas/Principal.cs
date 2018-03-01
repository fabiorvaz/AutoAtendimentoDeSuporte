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
    public partial class Principal : Form
    {
		public Principal()
        {
            InitializeComponent();
        }

        private void btnThunderbird_Click(object sender, EventArgs e)
        {
            Thunderbird.Thunderbird janela = new Thunderbird.Thunderbird();
            janela.ShowDialog();
        }

        private void btnLibreOffice_Click(object sender, EventArgs e)
        {
            LibreOffice.LibreOffice janela = new LibreOffice.LibreOffice();
            janela.ShowDialog();
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (Keys.F10.Equals(e.KeyChar))
                { }
            }
        }

        private void btnThunderbird_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (Keys.F10.Equals(e.KeyCode))
                {
                    Autenticacao janela = new Autenticacao();
                    janela.ShowDialog();
                    if (Lib.Configuracoes.Autenticado)
                    {
						AtualizarTela();
                    }
                }
            }
        }

        private void btnDisco_Click(object sender, EventArgs e)
        {
            Disco.Disco janela = new Disco.Disco();
            janela.ShowDialog();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            Sistema.Sistema janela = new Sistema.Sistema();
            janela.ShowDialog();
        }

        private void btnImpressora_Click(object sender, EventArgs e)
        {
            Impressora.Impressora janela = new Impressora.Impressora();
            janela.ShowDialog();
        }

		private void AtualizarTela()
		{
			// Atualiza os botões e tamanho da tela conforme o operador é 
			// power-user (TI) ou normal

			if (Lib.Configuracoes.Autenticado)
			{
				btnDisco.Visible = true;
				btnSistema.Visible = true;

				// Somente ativa o link para rodar como admin caso
				// não esteja rodando como admin
				linkRunAsAdmin.Visible = !Lib.Configuracoes.IsElevated;
			}
			else
			{
				btnDisco.Visible = false;
				btnSistema.Visible = false;
				linkRunAsAdmin.Visible = false;
			}

			// Atualiza a altura do form conforme os botões visíveis
			UpdateFormHeight();
		}

		private void Principal_Load(object sender, EventArgs e)
		{

		}

		private void Principal_Shown(object sender, EventArgs e)
		{
			// Atualiza o título da tela conforme permissões de administrador
			if (Lib.Configuracoes.IsElevated)
				this.Text += " (Admin)";

			AtualizarTela();
		}

		///<summary>Atualiza a altura do form conforme os botões visíveis</summary>
		private void UpdateFormHeight()
		{
			int maxHeight = 0;
			foreach(Control control in this.Controls)
			{
				if (control.Visible)
				{
					maxHeight = Math.Max(control.Top + control.Height, maxHeight);
				}
			}

			if (maxHeight == 0)
				return;

			maxHeight += 16;

			this.Height = maxHeight + (this.Height - this.ClientSize.Height);
		}

		private void linkRunAsAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Lib.Configuracoes.TryElevateRights();
		}
	}
}
