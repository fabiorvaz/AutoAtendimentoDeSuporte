namespace SuporteSolution.Telas.Thunderbird
{
    partial class Thunderbird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thunderbird));
            this.btnRestauraLixeira = new System.Windows.Forms.Button();
            this.btnGerarAssinatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestauraLixeira
            // 
            this.btnRestauraLixeira.Image = ((System.Drawing.Image)(resources.GetObject("btnRestauraLixeira.Image")));
            this.btnRestauraLixeira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestauraLixeira.Location = new System.Drawing.Point(12, 12);
            this.btnRestauraLixeira.Name = "btnRestauraLixeira";
            this.btnRestauraLixeira.Size = new System.Drawing.Size(154, 85);
            this.btnRestauraLixeira.TabIndex = 1;
            this.btnRestauraLixeira.Text = "Restaurar lixeira";
            this.btnRestauraLixeira.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestauraLixeira.UseVisualStyleBackColor = true;
            this.btnRestauraLixeira.Click += new System.EventHandler(this.btnRestauraLixeira_Click);
            // 
            // btnGerarAssinatura
            // 
            this.btnGerarAssinatura.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarAssinatura.Image")));
            this.btnGerarAssinatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarAssinatura.Location = new System.Drawing.Point(186, 12);
            this.btnGerarAssinatura.Name = "btnGerarAssinatura";
            this.btnGerarAssinatura.Size = new System.Drawing.Size(154, 85);
            this.btnGerarAssinatura.TabIndex = 2;
            this.btnGerarAssinatura.Text = "Gerar assinatura";
            this.btnGerarAssinatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerarAssinatura.UseVisualStyleBackColor = true;
            this.btnGerarAssinatura.Visible = false;
            this.btnGerarAssinatura.Click += new System.EventHandler(this.btnGerarAssinatura_Click);
            // 
            // Thunderbird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 109);
            this.Controls.Add(this.btnGerarAssinatura);
            this.Controls.Add(this.btnRestauraLixeira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Thunderbird";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Autoatendimento - Thunderbird";
            this.Load += new System.EventHandler(this.Thunderbird_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestauraLixeira;
        private System.Windows.Forms.Button btnGerarAssinatura;
    }
}