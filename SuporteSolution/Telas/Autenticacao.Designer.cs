namespace SuporteSolution.Telas
{
    partial class Autenticacao
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAutenticar = new System.Windows.Forms.Button();
			this.labelVersao = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(15, 25);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(257, 20);
			this.txtSenha.TabIndex = 1;
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Image = global::SuporteSolution.Properties.Resources.door_in;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(15, 51);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 23);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAutenticar
			// 
			this.btnAutenticar.Image = global::SuporteSolution.Properties.Resources.key;
			this.btnAutenticar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAutenticar.Location = new System.Drawing.Point(167, 51);
			this.btnAutenticar.Name = "btnAutenticar";
			this.btnAutenticar.Size = new System.Drawing.Size(105, 23);
			this.btnAutenticar.TabIndex = 3;
			this.btnAutenticar.Text = "Autenticar";
			this.btnAutenticar.UseVisualStyleBackColor = true;
			this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
			// 
			// labelVersao
			// 
			this.labelVersao.AutoSize = true;
			this.labelVersao.Location = new System.Drawing.Point(12, 98);
			this.labelVersao.Name = "labelVersao";
			this.labelVersao.Size = new System.Drawing.Size(62, 13);
			this.labelVersao.TabIndex = 4;
			this.labelVersao.Text = "labelVersao";
			// 
			// Autenticacao
			// 
			this.AcceptButton = this.btnAutenticar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(284, 124);
			this.ControlBox = false;
			this.Controls.Add(this.labelVersao);
			this.Controls.Add(this.btnAutenticar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimizeBox = false;
			this.Name = "Autenticacao";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autenticação";
			this.Load += new System.EventHandler(this.Autenticacao_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAutenticar;
		private System.Windows.Forms.Label labelVersao;
	}
}