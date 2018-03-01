using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuporteSolution.Telas.Disco
{
    public partial class CopiarDados : Form
    {
        Dictionary<string, string> listaDiscos = Lib.Disco.Disco.Default.ListaDiscos;

        public CopiarDados()
        {
            InitializeComponent();
        }

        private void CopiarDados_Load(object sender, EventArgs e)
        {
            CarregarListaDeDiscos();
            if (!Lib.Configuracoes.IsElevated)
            {
                outrasOpcoesRbAutoBusca.Checked = true ;
                outrasOpcoesRbRegistro.Enabled = false;
            }
        }

        private void CarregarListaDeDiscos()
        {
            cbDiscoDestino.DataSource = new BindingSource(listaDiscos, null);
            cbDiscoDestino.DisplayMember = "Value";
            cbDiscoDestino.ValueMember = "Key";

            cbDiscoOrigem.DataSource = new BindingSource(listaDiscos, null);
            cbDiscoOrigem.DisplayMember = "Value";
            cbDiscoOrigem.ValueMember = "Key";
        }

        private void btnCopairDados_Click(object sender, EventArgs e)
        {
            if (cbDiscoDestino.SelectedValue == cbDiscoOrigem.SelectedValue)
            {
                MessageBox.Show("Disco de origem e de destino são o mesmo, a cópia não será feita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<object> arguments = new List<object>();
            arguments.Add(cbDiscoOrigem.SelectedValue.ToString());
            arguments.Add(cbDiscoDestino.SelectedValue.ToString());

            if (outrasOpcoesRbAutoBusca.Checked)
            {
                arguments.Add("Autobusca");
                if (pastaUsuarioRbNao.Checked)
                {
                    if (pastaUsuarioTxtPastaAntigo.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco antigo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (pastaUsuarioTxtPastaNovo.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!pastaUsuarioTxtPastaAntigo.Text.Contains(cbDiscoOrigem.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario antigo deve ser no disco de origem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!pastaUsuarioTxtPastaNovo.Text.Contains(cbDiscoDestino.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario novo deve ser no disco de destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    arguments.Add("PastaUsarioAntigo|" + pastaUsuarioTxtPastaAntigo.Text);
                    arguments.Add("PastaUsarioNova|" + pastaUsuarioTxtPastaNovo.Text);
                }
                if (appDataRbNao.Checked)
                {
                    if (appDataTxtPastaAntiga.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco antigo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (appDataTxtPastaNova.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!appDataTxtPastaAntiga.Text.Contains(cbDiscoOrigem.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario antigo deve ser no disco de origem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!appDataTxtPastaNova.Text.Contains(cbDiscoDestino.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario novo deve ser no disco de destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    arguments.Add("AppDataAntigo|" + appDataTxtPastaAntiga.Text);
                    arguments.Add("AppDataNova|" + appDataTxtPastaNova.Text);
                }
                if (dadosRbNao.Checked)
                {
                    if (dadosTxtPastaAntiga.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco antigo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (dadosTxtPastaNova.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!dadosTxtPastaAntiga.Text.Contains(cbDiscoOrigem.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario antigo deve ser no disco de origem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!dadosTxtPastaNova.Text.Contains(cbDiscoDestino.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario novo deve ser no disco de destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    arguments.Add("dadosAntigo|" + dadosTxtPastaAntiga.Text);
                    arguments.Add("dadosNova|" + dadosTxtPastaNova.Text);
                }
            }
            else
            {
                arguments.Add("Registro");
                if (dadosRbNao.Checked || appDataRbNao.Checked)
                    if (DialogResult.No == MessageBox.Show("AVISO: Na busca por registro o programa NÃO usará as opções das abas \"App data\" e \"Pasta de dados\". \nDeseja continuar com a cópia?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        return;

                if (pastaUsuarioRbNao.Checked)
                {
                    if (pastaUsuarioTxtPastaAntigo.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco antigo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (pastaUsuarioTxtPastaNovo.Text == "")
                    {
                        MessageBox.Show("Selecione uma pasta de usuario do disco novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!pastaUsuarioTxtPastaAntigo.Text.Contains(cbDiscoOrigem.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario antigo deve ser no disco de origem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!pastaUsuarioTxtPastaNovo.Text.Contains(cbDiscoDestino.SelectedValue.ToString()))
                    {
                        MessageBox.Show("A pasta de usuario novo deve ser no disco de destino.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    arguments.Add("PastaUsarioAntigo|" + pastaUsuarioTxtPastaAntigo.Text);
                    arguments.Add("PastaUsarioNova|" + pastaUsuarioTxtPastaNovo.Text);
                }
            }
            SplashScreenAplicando janela = new SplashScreenAplicando();
            janela.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            janela.arguments = arguments;
            janela.ShowDialog();
            MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> arguments = e.Argument as List<object>;
            for (int i = 3; i < arguments.Count; i++)
            {
                string arg = arguments[i].ToString();
                if (arg.Contains("PastaUsarioAntigo"))
                {
                    Lib.Disco.CopiaDisco.pastaUsuarioAntigo=arg.Split('|')[1];
                }
                if (arg.Contains("PastaUsarioNova"))
                {
                    Lib.Disco.CopiaDisco.pastaUsuarioNovo = arg.Split('|')[1];
                }
                if (arg.Contains("AppDataAntigo"))
                {
                    Lib.Disco.CopiaDisco.pastaAppAntigo = arg.Split('|')[1];
                }
                if (arg.Contains("AppDataNova"))
                {
                    Lib.Disco.CopiaDisco.pastaAppNovo = arg.Split('|')[1];
                }
                if (arg.Contains("dadosAntigo"))
                {
                    Lib.Disco.CopiaDisco.pastaDadosAntigo = arg.Split('|')[1];
                }
                if (arg.Contains("dadosNova"))
                {
                    Lib.Disco.CopiaDisco.pastaDadosNovo = arg.Split('|')[1];
                }
            }
            if(arguments[2]=="Autobusca")
                Lib.Disco.CopiaDisco.CopiarDadosViaAutoBusca(arguments[0].ToString(),arguments[1].ToString());
            else
                Lib.Disco.CopiaDisco.CopiarDadosViaRegistro(arguments[0].ToString(), arguments[1].ToString());
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            if (btnOpcoes.Text.Contains(">>"))
            {
                this.Width = this.Size.Width + pnlOpcoes.Size.Width;
                btnOpcoes.Text = "Opções Avançadas <<";
            }
            else
            {
                this.Width = this.Size.Width - pnlOpcoes.Size.Width;
                btnOpcoes.Text = "Opções Avançadas >>";
            }
        }

        private void pastaUsuarioRbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (pastaUsuarioRbNao.Checked)
            {
                pastaUsuarioPnlPastas.Enabled = true;
            }
            else
            {
                pastaUsuarioPnlPastas.Enabled = false;
            }
        }

        private void pastaUsuarioBtnPastaAntigo_Click(object sender, EventArgs e)
        {
            string pasta = selecionarPasta();
            if (pasta != "")
            {
                pastaUsuarioTxtPastaAntigo.Text = pasta;
            }
        }

        private string selecionarPasta()
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                return folderBrowserDialog1.SelectedPath;
            }
            return "";
        }

        private void pastaUsuarioBtnPastaNovo_Click(object sender, EventArgs e)
        {
            string pasta = selecionarPasta();
            if (pasta != "")
            {
                pastaUsuarioTxtPastaNovo.Text = pasta;
            }
        }

        private void appDataBtnPastaAntiga_Click(object sender, EventArgs e)
        {
            string pasta = selecionarPasta();
            if (pasta != "")
            {
                appDataTxtPastaAntiga.Text = pasta;
            }
        }

        private void appDataPastaNova_Click(object sender, EventArgs e)
        {
            string pasta = selecionarPasta();
            if (pasta != "")
            {
                appDataTxtPastaNova.Text = pasta;
            }
        }

        private void appDataRbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (appDataRbNao.Checked)
            {
                appDataPnlPastas.Enabled = true;
            }
            else
            {
                appDataPnlPastas.Enabled = false;
            }
        }

        private void dadosRbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (dadosRbNao.Checked)
            {
                dadosPnlPastas.Enabled = true;
            }
            else
            {
                dadosPnlPastas.Enabled = false;
            }
        }

        private void dadosBtnPastaAntiga_Click(object sender, EventArgs e)
        {
            string pasta = selecionarPasta();
            if (pasta != "")
            {
                dadosTxtPastaAntiga.Text = pasta;
            }
        }

        private void dadosBtnPastaNova_Click(object sender, EventArgs e)
        {
            string pasta = selecionarPasta();
            if (pasta != "")
            {
                dadosTxtPastaNova.Text = pasta;
            }
        }
    }
}
