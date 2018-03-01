namespace SuporteSolution.Telas.LibreOffice
{
    partial class LibreOffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibreOffice));
            this.btnRestauraLixeira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestauraLixeira
            // 
            this.btnRestauraLixeira.Image = ((System.Drawing.Image)(resources.GetObject("btnRestauraLixeira.Image")));
            this.btnRestauraLixeira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestauraLixeira.Location = new System.Drawing.Point(12, 12);
            this.btnRestauraLixeira.Name = "btnRestauraLixeira";
            this.btnRestauraLixeira.Size = new System.Drawing.Size(154, 85);
            this.btnRestauraLixeira.TabIndex = 2;
            this.btnRestauraLixeira.Text = "Destravar \r\nLibre Office";
            this.btnRestauraLixeira.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestauraLixeira.UseVisualStyleBackColor = true;
            this.btnRestauraLixeira.Click += new System.EventHandler(this.btnRestauraLixeira_Click);
            // 
            // LibreOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 107);
            this.Controls.Add(this.btnRestauraLixeira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LibreOffice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Autoatendimento - LibreOffice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestauraLixeira;
    }
}