namespace SuporteSolution.Telas.Impressora
{
    partial class Impressora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impressora));
            this.btnCopairDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopairDados
            // 
            this.btnCopairDados.Image = ((System.Drawing.Image)(resources.GetObject("btnCopairDados.Image")));
            this.btnCopairDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopairDados.Location = new System.Drawing.Point(12, 12);
            this.btnCopairDados.Name = "btnCopairDados";
            this.btnCopairDados.Size = new System.Drawing.Size(154, 85);
            this.btnCopairDados.TabIndex = 3;
            this.btnCopairDados.Text = "Limpar fila";
            this.btnCopairDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopairDados.UseVisualStyleBackColor = true;
            this.btnCopairDados.Click += new System.EventHandler(this.btnCopairDados_Click);
            // 
            // Impressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 105);
            this.Controls.Add(this.btnCopairDados);
            this.Name = "Impressora";
            this.Text = "Impressora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopairDados;
    }
}