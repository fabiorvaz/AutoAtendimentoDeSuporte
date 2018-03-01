namespace SuporteSolution.Telas.Disco
{
    partial class Disco
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disco));
			this.btnCopairDados = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCopairDados
			// 
			this.btnCopairDados.Image = ((System.Drawing.Image)(resources.GetObject("btnCopairDados.Image")));
			this.btnCopairDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCopairDados.Location = new System.Drawing.Point(12, 12);
			this.btnCopairDados.Name = "btnCopairDados";
			this.btnCopairDados.Size = new System.Drawing.Size(154, 85);
			this.btnCopairDados.TabIndex = 2;
			this.btnCopairDados.Text = "Copiar Dados";
			this.btnCopairDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCopairDados.UseVisualStyleBackColor = true;
			this.btnCopairDados.Click += new System.EventHandler(this.btnCopairDados_Click);
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(171, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 85);
			this.button1.TabIndex = 3;
			this.button1.Text = "Limpar Dados";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Disco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 105);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCopairDados);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Disco";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Disco";
			this.Load += new System.EventHandler(this.Disco_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopairDados;
        private System.Windows.Forms.Button button1;
    }
}