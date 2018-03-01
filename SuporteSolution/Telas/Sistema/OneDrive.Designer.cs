namespace SuporteSolution.Telas.Sistema
{
	partial class OneDrive
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneDrive));
			this.btnAtivar = new System.Windows.Forms.Button();
			this.btnDesativar = new System.Windows.Forms.Button();
			this.btnDesisntalar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAtivar
			// 
			this.btnAtivar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtivar.Image")));
			this.btnAtivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAtivar.Location = new System.Drawing.Point(12, 10);
			this.btnAtivar.Name = "btnAtivar";
			this.btnAtivar.Size = new System.Drawing.Size(154, 85);
			this.btnAtivar.TabIndex = 5;
			this.btnAtivar.Text = "Ativar\r\nOne Drive";
			this.btnAtivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAtivar.UseVisualStyleBackColor = true;
			this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
			// 
			// btnDesativar
			// 
			this.btnDesativar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesativar.Image")));
			this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDesativar.Location = new System.Drawing.Point(187, 10);
			this.btnDesativar.Name = "btnDesativar";
			this.btnDesativar.Size = new System.Drawing.Size(154, 85);
			this.btnDesativar.TabIndex = 6;
			this.btnDesativar.Text = "Desativar\r\nOne Drive";
			this.btnDesativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDesativar.UseVisualStyleBackColor = true;
			this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
			// 
			// btnDesisntalar
			// 
			this.btnDesisntalar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesisntalar.Image")));
			this.btnDesisntalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDesisntalar.Location = new System.Drawing.Point(12, 101);
			this.btnDesisntalar.Name = "btnDesisntalar";
			this.btnDesisntalar.Size = new System.Drawing.Size(154, 85);
			this.btnDesisntalar.TabIndex = 7;
			this.btnDesisntalar.Text = "Desinstalar\r\nOne Drive";
			this.btnDesisntalar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDesisntalar.UseVisualStyleBackColor = true;
			this.btnDesisntalar.Click += new System.EventHandler(this.button1_Click);
			// 
			// OneDrive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 196);
			this.Controls.Add(this.btnDesisntalar);
			this.Controls.Add(this.btnDesativar);
			this.Controls.Add(this.btnAtivar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OneDrive";
			this.Text = "OneDrive";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAtivar;
		private System.Windows.Forms.Button btnDesativar;
		private System.Windows.Forms.Button btnDesisntalar;
	}
}