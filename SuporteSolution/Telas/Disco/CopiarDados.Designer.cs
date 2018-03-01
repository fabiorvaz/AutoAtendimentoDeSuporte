namespace SuporteSolution.Telas.Disco
{
    partial class CopiarDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopiarDados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDiscoOrigem = new System.Windows.Forms.ComboBox();
            this.cbDiscoDestino = new System.Windows.Forms.ComboBox();
            this.btnCopairDados = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pastaUsuarioPnlPastas = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pastaUsuarioBtnPastaNovo = new System.Windows.Forms.Button();
            this.pastaUsuarioTxtPastaNovo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pastaUsuarioBtnPastaAntigo = new System.Windows.Forms.Button();
            this.pastaUsuarioTxtPastaAntigo = new System.Windows.Forms.TextBox();
            this.pastaUsuarioRbNao = new System.Windows.Forms.RadioButton();
            this.pastaUsuarioRbSim = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.appDataPnlPastas = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.appDataPastaNova = new System.Windows.Forms.Button();
            this.appDataTxtPastaNova = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.appDataBtnPastaAntiga = new System.Windows.Forms.Button();
            this.appDataTxtPastaAntiga = new System.Windows.Forms.TextBox();
            this.appDataRbNao = new System.Windows.Forms.RadioButton();
            this.appDataRbSim = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dadosPnlPastas = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dadosBtnPastaNova = new System.Windows.Forms.Button();
            this.dadosTxtPastaNova = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dadosBtnPastaAntiga = new System.Windows.Forms.Button();
            this.dadosTxtPastaAntiga = new System.Windows.Forms.TextBox();
            this.dadosRbNao = new System.Windows.Forms.RadioButton();
            this.dadosRbSim = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outrasOpcoesRbRegistro = new System.Windows.Forms.RadioButton();
            this.outrasOpcoesRbAutoBusca = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlOpcoes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pastaUsuarioPnlPastas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.appDataPnlPastas.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.dadosPnlPastas.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disco de origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disco de destino:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Atenção: Essa rotina não removerá os dados do disco de destino, apenas adiocionar" +
    "á novos dados.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Atenção: Essa rotina não removerá os dados do disco de origem";
            // 
            // cbDiscoOrigem
            // 
            this.cbDiscoOrigem.FormattingEnabled = true;
            this.cbDiscoOrigem.Location = new System.Drawing.Point(15, 101);
            this.cbDiscoOrigem.Name = "cbDiscoOrigem";
            this.cbDiscoOrigem.Size = new System.Drawing.Size(252, 21);
            this.cbDiscoOrigem.TabIndex = 5;
            // 
            // cbDiscoDestino
            // 
            this.cbDiscoDestino.FormattingEnabled = true;
            this.cbDiscoDestino.Location = new System.Drawing.Point(15, 155);
            this.cbDiscoDestino.Name = "cbDiscoDestino";
            this.cbDiscoDestino.Size = new System.Drawing.Size(252, 21);
            this.cbDiscoDestino.TabIndex = 6;
            // 
            // btnCopairDados
            // 
            this.btnCopairDados.Image = ((System.Drawing.Image)(resources.GetObject("btnCopairDados.Image")));
            this.btnCopairDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopairDados.Location = new System.Drawing.Point(60, 186);
            this.btnCopairDados.Name = "btnCopairDados";
            this.btnCopairDados.Size = new System.Drawing.Size(154, 85);
            this.btnCopairDados.TabIndex = 7;
            this.btnCopairDados.Text = "Copiar Dados";
            this.btnCopairDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopairDados.UseVisualStyleBackColor = true;
            this.btnCopairDados.Click += new System.EventHandler(this.btnCopairDados_Click);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Location = new System.Drawing.Point(15, 296);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(252, 23);
            this.btnOpcoes.TabIndex = 8;
            this.btnOpcoes.Text = "Opções Avançadas >>";
            this.btnOpcoes.UseVisualStyleBackColor = true;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.Controls.Add(this.tabControl1);
            this.pnlOpcoes.Location = new System.Drawing.Point(286, 17);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(331, 301);
            this.pnlOpcoes.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pastaUsuarioPnlPastas);
            this.tabPage1.Controls.Add(this.pastaUsuarioRbNao);
            this.tabPage1.Controls.Add(this.pastaUsuarioRbSim);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pasta do usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pastaUsuarioPnlPastas
            // 
            this.pastaUsuarioPnlPastas.Controls.Add(this.label7);
            this.pastaUsuarioPnlPastas.Controls.Add(this.pastaUsuarioBtnPastaNovo);
            this.pastaUsuarioPnlPastas.Controls.Add(this.pastaUsuarioTxtPastaNovo);
            this.pastaUsuarioPnlPastas.Controls.Add(this.label6);
            this.pastaUsuarioPnlPastas.Controls.Add(this.pastaUsuarioBtnPastaAntigo);
            this.pastaUsuarioPnlPastas.Controls.Add(this.pastaUsuarioTxtPastaAntigo);
            this.pastaUsuarioPnlPastas.Enabled = false;
            this.pastaUsuarioPnlPastas.Location = new System.Drawing.Point(0, 46);
            this.pastaUsuarioPnlPastas.Name = "pastaUsuarioPnlPastas";
            this.pastaUsuarioPnlPastas.Size = new System.Drawing.Size(323, 229);
            this.pastaUsuarioPnlPastas.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pasta do usuario novo";
            // 
            // pastaUsuarioBtnPastaNovo
            // 
            this.pastaUsuarioBtnPastaNovo.Location = new System.Drawing.Point(287, 69);
            this.pastaUsuarioBtnPastaNovo.Name = "pastaUsuarioBtnPastaNovo";
            this.pastaUsuarioBtnPastaNovo.Size = new System.Drawing.Size(25, 23);
            this.pastaUsuarioBtnPastaNovo.TabIndex = 8;
            this.pastaUsuarioBtnPastaNovo.Text = "...";
            this.pastaUsuarioBtnPastaNovo.UseVisualStyleBackColor = true;
            this.pastaUsuarioBtnPastaNovo.Click += new System.EventHandler(this.pastaUsuarioBtnPastaNovo_Click);
            // 
            // pastaUsuarioTxtPastaNovo
            // 
            this.pastaUsuarioTxtPastaNovo.Location = new System.Drawing.Point(10, 71);
            this.pastaUsuarioTxtPastaNovo.Name = "pastaUsuarioTxtPastaNovo";
            this.pastaUsuarioTxtPastaNovo.Size = new System.Drawing.Size(271, 20);
            this.pastaUsuarioTxtPastaNovo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pasta do usuario antigo";
            // 
            // pastaUsuarioBtnPastaAntigo
            // 
            this.pastaUsuarioBtnPastaAntigo.Location = new System.Drawing.Point(287, 23);
            this.pastaUsuarioBtnPastaAntigo.Name = "pastaUsuarioBtnPastaAntigo";
            this.pastaUsuarioBtnPastaAntigo.Size = new System.Drawing.Size(25, 23);
            this.pastaUsuarioBtnPastaAntigo.TabIndex = 5;
            this.pastaUsuarioBtnPastaAntigo.Text = "...";
            this.pastaUsuarioBtnPastaAntigo.UseVisualStyleBackColor = true;
            this.pastaUsuarioBtnPastaAntigo.Click += new System.EventHandler(this.pastaUsuarioBtnPastaAntigo_Click);
            // 
            // pastaUsuarioTxtPastaAntigo
            // 
            this.pastaUsuarioTxtPastaAntigo.Location = new System.Drawing.Point(10, 25);
            this.pastaUsuarioTxtPastaAntigo.Name = "pastaUsuarioTxtPastaAntigo";
            this.pastaUsuarioTxtPastaAntigo.Size = new System.Drawing.Size(271, 20);
            this.pastaUsuarioTxtPastaAntigo.TabIndex = 4;
            // 
            // pastaUsuarioRbNao
            // 
            this.pastaUsuarioRbNao.AutoSize = true;
            this.pastaUsuarioRbNao.Location = new System.Drawing.Point(93, 19);
            this.pastaUsuarioRbNao.Name = "pastaUsuarioRbNao";
            this.pastaUsuarioRbNao.Size = new System.Drawing.Size(45, 17);
            this.pastaUsuarioRbNao.TabIndex = 2;
            this.pastaUsuarioRbNao.Text = "Não";
            this.pastaUsuarioRbNao.UseVisualStyleBackColor = true;
            this.pastaUsuarioRbNao.CheckedChanged += new System.EventHandler(this.pastaUsuarioRbNao_CheckedChanged);
            // 
            // pastaUsuarioRbSim
            // 
            this.pastaUsuarioRbSim.AutoSize = true;
            this.pastaUsuarioRbSim.Checked = true;
            this.pastaUsuarioRbSim.Location = new System.Drawing.Point(10, 19);
            this.pastaUsuarioRbSim.Name = "pastaUsuarioRbSim";
            this.pastaUsuarioRbSim.Size = new System.Drawing.Size(42, 17);
            this.pastaUsuarioRbSim.TabIndex = 1;
            this.pastaUsuarioRbSim.TabStop = true;
            this.pastaUsuarioRbSim.Text = "Sim";
            this.pastaUsuarioRbSim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Localizar automaticamente a pasta do usuario?";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.appDataPnlPastas);
            this.tabPage2.Controls.Add(this.appDataRbNao);
            this.tabPage2.Controls.Add(this.appDataRbSim);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "App data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // appDataPnlPastas
            // 
            this.appDataPnlPastas.Controls.Add(this.label8);
            this.appDataPnlPastas.Controls.Add(this.appDataPastaNova);
            this.appDataPnlPastas.Controls.Add(this.appDataTxtPastaNova);
            this.appDataPnlPastas.Controls.Add(this.label9);
            this.appDataPnlPastas.Controls.Add(this.appDataBtnPastaAntiga);
            this.appDataPnlPastas.Controls.Add(this.appDataTxtPastaAntiga);
            this.appDataPnlPastas.Enabled = false;
            this.appDataPnlPastas.Location = new System.Drawing.Point(0, 46);
            this.appDataPnlPastas.Name = "appDataPnlPastas";
            this.appDataPnlPastas.Size = new System.Drawing.Size(323, 229);
            this.appDataPnlPastas.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Pasta nova";
            // 
            // appDataPastaNova
            // 
            this.appDataPastaNova.Location = new System.Drawing.Point(287, 69);
            this.appDataPastaNova.Name = "appDataPastaNova";
            this.appDataPastaNova.Size = new System.Drawing.Size(25, 23);
            this.appDataPastaNova.TabIndex = 8;
            this.appDataPastaNova.Text = "...";
            this.appDataPastaNova.UseVisualStyleBackColor = true;
            this.appDataPastaNova.Click += new System.EventHandler(this.appDataPastaNova_Click);
            // 
            // appDataTxtPastaNova
            // 
            this.appDataTxtPastaNova.Location = new System.Drawing.Point(10, 71);
            this.appDataTxtPastaNova.Name = "appDataTxtPastaNova";
            this.appDataTxtPastaNova.Size = new System.Drawing.Size(271, 20);
            this.appDataTxtPastaNova.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Pasta antiga";
            // 
            // appDataBtnPastaAntiga
            // 
            this.appDataBtnPastaAntiga.Location = new System.Drawing.Point(287, 23);
            this.appDataBtnPastaAntiga.Name = "appDataBtnPastaAntiga";
            this.appDataBtnPastaAntiga.Size = new System.Drawing.Size(25, 23);
            this.appDataBtnPastaAntiga.TabIndex = 5;
            this.appDataBtnPastaAntiga.Text = "...";
            this.appDataBtnPastaAntiga.UseVisualStyleBackColor = true;
            this.appDataBtnPastaAntiga.Click += new System.EventHandler(this.appDataBtnPastaAntiga_Click);
            // 
            // appDataTxtPastaAntiga
            // 
            this.appDataTxtPastaAntiga.Location = new System.Drawing.Point(10, 25);
            this.appDataTxtPastaAntiga.Name = "appDataTxtPastaAntiga";
            this.appDataTxtPastaAntiga.Size = new System.Drawing.Size(271, 20);
            this.appDataTxtPastaAntiga.TabIndex = 4;
            // 
            // appDataRbNao
            // 
            this.appDataRbNao.AutoSize = true;
            this.appDataRbNao.Location = new System.Drawing.Point(98, 22);
            this.appDataRbNao.Name = "appDataRbNao";
            this.appDataRbNao.Size = new System.Drawing.Size(45, 17);
            this.appDataRbNao.TabIndex = 9;
            this.appDataRbNao.Text = "Não";
            this.appDataRbNao.UseVisualStyleBackColor = true;
            this.appDataRbNao.CheckedChanged += new System.EventHandler(this.appDataRbNao_CheckedChanged);
            // 
            // appDataRbSim
            // 
            this.appDataRbSim.AutoSize = true;
            this.appDataRbSim.Checked = true;
            this.appDataRbSim.Location = new System.Drawing.Point(15, 22);
            this.appDataRbSim.Name = "appDataRbSim";
            this.appDataRbSim.Size = new System.Drawing.Size(42, 17);
            this.appDataRbSim.TabIndex = 8;
            this.appDataRbSim.TabStop = true;
            this.appDataRbSim.Text = "Sim";
            this.appDataRbSim.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Localizar automaticamente a pasta App Data?";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dadosPnlPastas);
            this.tabPage3.Controls.Add(this.dadosRbNao);
            this.tabPage3.Controls.Add(this.dadosRbSim);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(323, 275);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pasta de dados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dadosPnlPastas
            // 
            this.dadosPnlPastas.Controls.Add(this.label11);
            this.dadosPnlPastas.Controls.Add(this.dadosBtnPastaNova);
            this.dadosPnlPastas.Controls.Add(this.dadosTxtPastaNova);
            this.dadosPnlPastas.Controls.Add(this.label12);
            this.dadosPnlPastas.Controls.Add(this.dadosBtnPastaAntiga);
            this.dadosPnlPastas.Controls.Add(this.dadosTxtPastaAntiga);
            this.dadosPnlPastas.Enabled = false;
            this.dadosPnlPastas.Location = new System.Drawing.Point(0, 45);
            this.dadosPnlPastas.Name = "dadosPnlPastas";
            this.dadosPnlPastas.Size = new System.Drawing.Size(323, 230);
            this.dadosPnlPastas.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Pasta nova";
            // 
            // dadosBtnPastaNova
            // 
            this.dadosBtnPastaNova.Location = new System.Drawing.Point(287, 69);
            this.dadosBtnPastaNova.Name = "dadosBtnPastaNova";
            this.dadosBtnPastaNova.Size = new System.Drawing.Size(25, 23);
            this.dadosBtnPastaNova.TabIndex = 8;
            this.dadosBtnPastaNova.Text = "...";
            this.dadosBtnPastaNova.UseVisualStyleBackColor = true;
            this.dadosBtnPastaNova.Click += new System.EventHandler(this.dadosBtnPastaNova_Click);
            // 
            // dadosTxtPastaNova
            // 
            this.dadosTxtPastaNova.Location = new System.Drawing.Point(10, 71);
            this.dadosTxtPastaNova.Name = "dadosTxtPastaNova";
            this.dadosTxtPastaNova.Size = new System.Drawing.Size(271, 20);
            this.dadosTxtPastaNova.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Pasta antiga";
            // 
            // dadosBtnPastaAntiga
            // 
            this.dadosBtnPastaAntiga.Location = new System.Drawing.Point(287, 23);
            this.dadosBtnPastaAntiga.Name = "dadosBtnPastaAntiga";
            this.dadosBtnPastaAntiga.Size = new System.Drawing.Size(25, 23);
            this.dadosBtnPastaAntiga.TabIndex = 5;
            this.dadosBtnPastaAntiga.Text = "...";
            this.dadosBtnPastaAntiga.UseVisualStyleBackColor = true;
            this.dadosBtnPastaAntiga.Click += new System.EventHandler(this.dadosBtnPastaAntiga_Click);
            // 
            // dadosTxtPastaAntiga
            // 
            this.dadosTxtPastaAntiga.Location = new System.Drawing.Point(10, 25);
            this.dadosTxtPastaAntiga.Name = "dadosTxtPastaAntiga";
            this.dadosTxtPastaAntiga.Size = new System.Drawing.Size(271, 20);
            this.dadosTxtPastaAntiga.TabIndex = 4;
            // 
            // dadosRbNao
            // 
            this.dadosRbNao.AutoSize = true;
            this.dadosRbNao.Location = new System.Drawing.Point(98, 22);
            this.dadosRbNao.Name = "dadosRbNao";
            this.dadosRbNao.Size = new System.Drawing.Size(45, 17);
            this.dadosRbNao.TabIndex = 13;
            this.dadosRbNao.Text = "Não";
            this.dadosRbNao.UseVisualStyleBackColor = true;
            this.dadosRbNao.CheckedChanged += new System.EventHandler(this.dadosRbNao_CheckedChanged);
            // 
            // dadosRbSim
            // 
            this.dadosRbSim.AutoSize = true;
            this.dadosRbSim.Checked = true;
            this.dadosRbSim.Location = new System.Drawing.Point(15, 22);
            this.dadosRbSim.Name = "dadosRbSim";
            this.dadosRbSim.Size = new System.Drawing.Size(42, 17);
            this.dadosRbSim.TabIndex = 12;
            this.dadosRbSim.TabStop = true;
            this.dadosRbSim.Text = "Sim";
            this.dadosRbSim.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Localizar automaticamente a pasta dados?";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(323, 275);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Outras opções";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outrasOpcoesRbRegistro);
            this.groupBox1.Controls.Add(this.outrasOpcoesRbAutoBusca);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca de dados";
            // 
            // outrasOpcoesRbRegistro
            // 
            this.outrasOpcoesRbRegistro.AutoSize = true;
            this.outrasOpcoesRbRegistro.Checked = true;
            this.outrasOpcoesRbRegistro.Location = new System.Drawing.Point(17, 43);
            this.outrasOpcoesRbRegistro.Name = "outrasOpcoesRbRegistro";
            this.outrasOpcoesRbRegistro.Size = new System.Drawing.Size(244, 17);
            this.outrasOpcoesRbRegistro.TabIndex = 1;
            this.outrasOpcoesRbRegistro.TabStop = true;
            this.outrasOpcoesRbRegistro.Text = "Busca inteligente (Requer modo administrador)";
            this.outrasOpcoesRbRegistro.UseVisualStyleBackColor = true;
            // 
            // outrasOpcoesRbAutoBusca
            // 
            this.outrasOpcoesRbAutoBusca.AutoSize = true;
            this.outrasOpcoesRbAutoBusca.Location = new System.Drawing.Point(17, 19);
            this.outrasOpcoesRbAutoBusca.Name = "outrasOpcoesRbAutoBusca";
            this.outrasOpcoesRbAutoBusca.Size = new System.Drawing.Size(127, 17);
            this.outrasOpcoesRbAutoBusca.TabIndex = 0;
            this.outrasOpcoesRbAutoBusca.Text = "Busca por força bruta";
            this.outrasOpcoesRbAutoBusca.UseVisualStyleBackColor = true;
            // 
            // CopiarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.pnlOpcoes);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.btnCopairDados);
            this.Controls.Add(this.cbDiscoDestino);
            this.Controls.Add(this.cbDiscoOrigem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CopiarDados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.CopiarDados_Load);
            this.pnlOpcoes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pastaUsuarioPnlPastas.ResumeLayout(false);
            this.pastaUsuarioPnlPastas.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.appDataPnlPastas.ResumeLayout(false);
            this.appDataPnlPastas.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.dadosPnlPastas.ResumeLayout(false);
            this.dadosPnlPastas.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDiscoOrigem;
        private System.Windows.Forms.ComboBox cbDiscoDestino;
        private System.Windows.Forms.Button btnCopairDados;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Panel pnlOpcoes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pastaUsuarioPnlPastas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button pastaUsuarioBtnPastaNovo;
        private System.Windows.Forms.TextBox pastaUsuarioTxtPastaNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pastaUsuarioBtnPastaAntigo;
        private System.Windows.Forms.TextBox pastaUsuarioTxtPastaAntigo;
        private System.Windows.Forms.RadioButton pastaUsuarioRbNao;
        private System.Windows.Forms.RadioButton pastaUsuarioRbSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel appDataPnlPastas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button appDataPastaNova;
        private System.Windows.Forms.TextBox appDataTxtPastaNova;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button appDataBtnPastaAntiga;
        private System.Windows.Forms.TextBox appDataTxtPastaAntiga;
        private System.Windows.Forms.RadioButton appDataRbNao;
        private System.Windows.Forms.RadioButton appDataRbSim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel dadosPnlPastas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button dadosBtnPastaNova;
        private System.Windows.Forms.TextBox dadosTxtPastaNova;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button dadosBtnPastaAntiga;
        private System.Windows.Forms.TextBox dadosTxtPastaAntiga;
        private System.Windows.Forms.RadioButton dadosRbNao;
        private System.Windows.Forms.RadioButton dadosRbSim;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton outrasOpcoesRbAutoBusca;
        private System.Windows.Forms.RadioButton outrasOpcoesRbRegistro;
    }
}