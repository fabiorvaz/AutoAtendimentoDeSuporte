namespace SuporteSolution.Telas.Sistema
{
    partial class Sistema
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
			this.btnInstalarProgramasPadrao = new System.Windows.Forms.Button();
			this.btnCortana = new System.Windows.Forms.Button();
			this.btnOneDrive = new System.Windows.Forms.Button();
			this.btnWsus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnInstalarProgramasPadrao
			// 
			this.btnInstalarProgramasPadrao.Image = ((System.Drawing.Image)(resources.GetObject("btnInstalarProgramasPadrao.Image")));
			this.btnInstalarProgramasPadrao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInstalarProgramasPadrao.Location = new System.Drawing.Point(12, 12);
			this.btnInstalarProgramasPadrao.Name = "btnInstalarProgramasPadrao";
			this.btnInstalarProgramasPadrao.Size = new System.Drawing.Size(154, 85);
			this.btnInstalarProgramasPadrao.TabIndex = 3;
			this.btnInstalarProgramasPadrao.Text = "Instalar \r\nprogramas\r\npadrão";
			this.btnInstalarProgramasPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInstalarProgramasPadrao.UseVisualStyleBackColor = true;
			this.btnInstalarProgramasPadrao.Click += new System.EventHandler(this.btnInstalarProgramasPadrao_Click);
			// 
			// btnCortana
			// 
			this.btnCortana.Image = ((System.Drawing.Image)(resources.GetObject("btnCortana.Image")));
			this.btnCortana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCortana.Location = new System.Drawing.Point(187, 12);
			this.btnCortana.Name = "btnCortana";
			this.btnCortana.Size = new System.Drawing.Size(154, 85);
			this.btnCortana.TabIndex = 4;
			this.btnCortana.Text = "Cortana";
			this.btnCortana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCortana.UseVisualStyleBackColor = true;
			this.btnCortana.Click += new System.EventHandler(this.btnCortana_Click);
			// 
			// btnOneDrive
			// 
			this.btnOneDrive.Image = ((System.Drawing.Image)(resources.GetObject("btnOneDrive.Image")));
			this.btnOneDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOneDrive.Location = new System.Drawing.Point(12, 103);
			this.btnOneDrive.Name = "btnOneDrive";
			this.btnOneDrive.Size = new System.Drawing.Size(154, 85);
			this.btnOneDrive.TabIndex = 5;
			this.btnOneDrive.Text = "One Drive";
			this.btnOneDrive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOneDrive.UseVisualStyleBackColor = true;
			this.btnOneDrive.Click += new System.EventHandler(this.btnOneDrive_Click);
			// 
			// btnWsus
			// 
			this.btnWsus.Image = ((System.Drawing.Image)(resources.GetObject("btnWsus.Image")));
			this.btnWsus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnWsus.Location = new System.Drawing.Point(187, 103);
			this.btnWsus.Name = "btnWsus";
			this.btnWsus.Size = new System.Drawing.Size(154, 85);
			this.btnWsus.TabIndex = 6;
			this.btnWsus.Text = "Wsus";
			this.btnWsus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnWsus.UseVisualStyleBackColor = true;
			this.btnWsus.Click += new System.EventHandler(this.btnWsus_Click);
			// 
			// Sistema
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 201);
			this.Controls.Add(this.btnWsus);
			this.Controls.Add(this.btnOneDrive);
			this.Controls.Add(this.btnCortana);
			this.Controls.Add(this.btnInstalarProgramasPadrao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Sistema";
			this.Text = "Sistema";
			this.Load += new System.EventHandler(this.Sistema_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstalarProgramasPadrao;
		private System.Windows.Forms.Button btnCortana;
		private System.Windows.Forms.Button btnOneDrive;
		private System.Windows.Forms.Button btnWsus;
	}
}