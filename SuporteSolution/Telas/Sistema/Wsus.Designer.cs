namespace SuporteSolution.Telas.Sistema
{
	partial class Wsus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wsus));
			this.btnAtivar = new System.Windows.Forms.Button();
			this.btnDesativar = new System.Windows.Forms.Button();
			this.btnReconfigurar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAtivar
			// 
			this.btnAtivar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtivar.Image")));
			this.btnAtivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAtivar.Location = new System.Drawing.Point(12, 12);
			this.btnAtivar.Name = "btnAtivar";
			this.btnAtivar.Size = new System.Drawing.Size(154, 85);
			this.btnAtivar.TabIndex = 6;
			this.btnAtivar.Text = "Ativar\r\nWSUS";
			this.btnAtivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAtivar.UseVisualStyleBackColor = true;
			this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
			// 
			// btnDesativar
			// 
			this.btnDesativar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesativar.Image")));
			this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDesativar.Location = new System.Drawing.Point(187, 12);
			this.btnDesativar.Name = "btnDesativar";
			this.btnDesativar.Size = new System.Drawing.Size(154, 85);
			this.btnDesativar.TabIndex = 7;
			this.btnDesativar.Text = "Desativar\r\nWSUS\r\n";
			this.btnDesativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDesativar.UseVisualStyleBackColor = true;
			this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
			// 
			// btnReconfigurar
			// 
			this.btnReconfigurar.Image = ((System.Drawing.Image)(resources.GetObject("btnReconfigurar.Image")));
			this.btnReconfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReconfigurar.Location = new System.Drawing.Point(12, 104);
			this.btnReconfigurar.Name = "btnReconfigurar";
			this.btnReconfigurar.Size = new System.Drawing.Size(154, 85);
			this.btnReconfigurar.TabIndex = 8;
			this.btnReconfigurar.Text = "Reconfigurar\r\nWSUS";
			this.btnReconfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReconfigurar.UseVisualStyleBackColor = true;
			this.btnReconfigurar.Click += new System.EventHandler(this.btnReconfigurar_Click);
			// 
			// Wsus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 201);
			this.Controls.Add(this.btnReconfigurar);
			this.Controls.Add(this.btnDesativar);
			this.Controls.Add(this.btnAtivar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Wsus";
			this.Text = "Wsus";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAtivar;
		private System.Windows.Forms.Button btnDesativar;
		private System.Windows.Forms.Button btnReconfigurar;
	}
}