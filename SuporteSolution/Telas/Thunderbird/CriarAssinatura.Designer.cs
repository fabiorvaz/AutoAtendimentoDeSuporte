namespace SuporteSolution.Telas.Thunderbird
{
    partial class CriarAssinatura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarAssinatura));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSetor = new System.Windows.Forms.TextBox();
			this.txtRamal = new System.Windows.Forms.TextBox();
			this.cbModelo = new System.Windows.Forms.ComboBox();
			this.btnGerarAssinatura = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(251, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ramal:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Setor:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Modelo";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(18, 32);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(355, 20);
			this.txtEmail.TabIndex = 5;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(18, 81);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(355, 20);
			this.txtNome.TabIndex = 6;
			// 
			// txtSetor
			// 
			this.txtSetor.Location = new System.Drawing.Point(18, 130);
			this.txtSetor.Name = "txtSetor";
			this.txtSetor.Size = new System.Drawing.Size(218, 20);
			this.txtSetor.TabIndex = 7;
			// 
			// txtRamal
			// 
			this.txtRamal.Location = new System.Drawing.Point(254, 130);
			this.txtRamal.Name = "txtRamal";
			this.txtRamal.Size = new System.Drawing.Size(119, 20);
			this.txtRamal.TabIndex = 8;
			// 
			// cbModelo
			// 
			this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbModelo.FormattingEnabled = true;
			this.cbModelo.Items.AddRange(new object[] {
            "Padrão",
            "Vendas 2016"});
			this.cbModelo.Location = new System.Drawing.Point(18, 179);
			this.cbModelo.Name = "cbModelo";
			this.cbModelo.Size = new System.Drawing.Size(355, 21);
			this.cbModelo.TabIndex = 9;
			// 
			// btnGerarAssinatura
			// 
			this.btnGerarAssinatura.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarAssinatura.Image")));
			this.btnGerarAssinatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGerarAssinatura.Location = new System.Drawing.Point(101, 221);
			this.btnGerarAssinatura.Name = "btnGerarAssinatura";
			this.btnGerarAssinatura.Size = new System.Drawing.Size(154, 85);
			this.btnGerarAssinatura.TabIndex = 10;
			this.btnGerarAssinatura.Text = "Gerar assinatura";
			this.btnGerarAssinatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGerarAssinatura.UseVisualStyleBackColor = true;
			this.btnGerarAssinatura.Click += new System.EventHandler(this.btnGerarAssinatura_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "html";
			this.saveFileDialog1.Filter = "Modelo HTML|*.html|Todos os arquivos|*.*";
			this.saveFileDialog1.Title = "Salvar o modelo";
			// 
			// CriarAssinatura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 318);
			this.Controls.Add(this.btnGerarAssinatura);
			this.Controls.Add(this.cbModelo);
			this.Controls.Add(this.txtRamal);
			this.Controls.Add(this.txtSetor);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CriarAssinatura";
			this.Text = "Gerar Assinatura";
			this.Load += new System.EventHandler(this.CriarAssinatura_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Button btnGerarAssinatura;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}