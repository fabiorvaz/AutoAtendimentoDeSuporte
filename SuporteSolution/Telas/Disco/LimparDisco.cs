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
    public partial class LimparDisco : Form
    {
        Dictionary<string, string> listaDiscos = Lib.Disco.Disco.Default.ListaDiscos;

        public LimparDisco()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CarregarListaDeDiscos()
        {
            cbDiscoOrigem.DataSource = new BindingSource(listaDiscos, null);
            cbDiscoOrigem.DisplayMember = "Value";
            cbDiscoOrigem.ValueMember = "Key";
        }

        private void LimparDisco_Load(object sender, EventArgs e)
        {
            CarregarListaDeDiscos();
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            List<object> arguments = new List<object>();
            arguments.Add(cbDiscoOrigem.SelectedValue.ToString());
            SplashScreenAplicando janela = new SplashScreenAplicando();
            janela.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            janela.arguments = arguments;
            janela.ShowDialog();
            MessageBox.Show("Procedimento concluido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> arguments = e.Argument as List<object>;
           
            //if (arguments[2] == "Autobusca")
            //    Lib.Disco.CopiaDisco.CopiarDadosViaAutoBusca(arguments[0].ToString(), arguments[1].ToString());
            //else
                Lib.Disco.LimpaDisco.LimparDadosViaRegistro(arguments[0].ToString());
        }
    }
}
