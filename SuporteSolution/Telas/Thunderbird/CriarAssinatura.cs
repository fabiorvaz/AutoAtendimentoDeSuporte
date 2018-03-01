using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuporteSolution.Telas.Thunderbird
{
	public partial class CriarAssinatura : Form
	{
		private const string P_DEFAULT_SAVE_DIR = "C:\\TEMP";

		public CriarAssinatura()
		{
			InitializeComponent();
		}

		private void btnGerarAssinatura_Click(object sender, EventArgs e)
		{
			if (!ValidarCampos())
				return;

			string selecionado = cbModelo.SelectedItem.ToString();
			string conteudo = "";
			if (selecionado.ToLower().Contains("padrão"))
			{
				conteudo = Properties.Resources.ModeloPadrao.ToString();
			}
			if (selecionado.ToLower().Contains("2016"))
			{
				conteudo = Properties.Resources.ModeloVendas2016.ToString();
			}

			conteudo = conteudo.Replace("[nome]", txtNome.Text).Replace("[email]", txtEmail.Text).Replace("[setor]", txtSetor.Text).Replace("[ramal]", txtRamal.Text);

			if (Directory.Exists(P_DEFAULT_SAVE_DIR))
				saveFileDialog1.InitialDirectory = P_DEFAULT_SAVE_DIR;
			saveFileDialog1.FileName = txtEmail.Text.Trim() + ".html";

			if (DialogResult.OK == saveFileDialog1.ShowDialog())
			{
				string arquivo = saveFileDialog1.FileName;
				File.WriteAllText(arquivo, conteudo);

				ViewHTML(arquivo);
			}
		}

		private void ViewHTML(string fileName)
		{
			var psi = new ProcessStartInfo(fileName);
			psi.UseShellExecute = true;

			try
			{
				using (var p = Process.Start(psi))
				{ }
			}
			catch(Exception ex)
			{
				MessageBox.Show(String.Format("{0} - {1}", ex.GetType().Name, ex.Message), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidarCampos()
		{
			if (!ValidarCampo(txtEmail, "Email")) return false;
			if (!ValidarCampo(txtNome, "Nome")) return false;
			if (!ValidarCampo(txtSetor, "Setor")) return false;
			if (!ValidarCampo(txtRamal, "Ramal")) return false;

			if (cbModelo.SelectedIndex < 0)
			{
				MessageBox.Show("Por favor, selecione um modelo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbModelo.Focus();
				return false;
			}

			if (!ValidarEmail(txtEmail.Text))
			{
				if (MessageBox.Show(@"Email '{txtEmail.Text}' não parece válido. Continuar?", "Email", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
				{
					txtEmail.Focus();
					return false;
				}
			}

			return true;
		}

		private bool ValidarEmail(string email)
		{
			if (email.IndexOf("@") <= 0)
				return false;

			if (email.IndexOf(".") <= 0)
				return false;

			if (!email.EndsWith("@olvebra.com.br"))
				return false;

			return true;
		}

		private bool ValidarCampo(TextBox input, string nomeCampo)
		{
			if (String.IsNullOrWhiteSpace(input.Text))
			{
				MessageBox.Show(String.Format("O campo {0} deve ser informado.", nomeCampo), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				input.Focus();
				return false;
			}
			return true;
		}

		private void CriarAssinatura_Load(object sender, EventArgs e)
		{

		}
	}
}
