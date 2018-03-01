namespace SuporteSolution.Telas
{
    partial class Principal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.btnLibreOffice = new System.Windows.Forms.Button();
			this.btnThunderbird = new System.Windows.Forms.Button();
			this.btnDisco = new System.Windows.Forms.Button();
			this.btnSistema = new System.Windows.Forms.Button();
			this.linkRunAsAdmin = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// btnLibreOffice
			// 
			this.btnLibreOffice.Image = ((System.Drawing.Image)(resources.GetObject("btnLibreOffice.Image")));
			this.btnLibreOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLibreOffice.Location = new System.Drawing.Point(185, 12);
			this.btnLibreOffice.Name = "btnLibreOffice";
			this.btnLibreOffice.Size = new System.Drawing.Size(154, 85);
			this.btnLibreOffice.TabIndex = 1;
			this.btnLibreOffice.Text = "LibreOffice";
			this.btnLibreOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLibreOffice.UseVisualStyleBackColor = true;
			this.btnLibreOffice.Click += new System.EventHandler(this.btnLibreOffice_Click);
			this.btnLibreOffice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThunderbird_KeyDown);
			this.btnLibreOffice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
			// 
			// btnThunderbird
			// 
			this.btnThunderbird.Image = ((System.Drawing.Image)(resources.GetObject("btnThunderbird.Image")));
			this.btnThunderbird.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThunderbird.Location = new System.Drawing.Point(12, 12);
			this.btnThunderbird.Name = "btnThunderbird";
			this.btnThunderbird.Size = new System.Drawing.Size(154, 85);
			this.btnThunderbird.TabIndex = 0;
			this.btnThunderbird.Text = "Thunderbird";
			this.btnThunderbird.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThunderbird.UseVisualStyleBackColor = true;
			this.btnThunderbird.Click += new System.EventHandler(this.btnThunderbird_Click);
			this.btnThunderbird.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThunderbird_KeyDown);
			this.btnThunderbird.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
			// 
			// btnDisco
			// 
			this.btnDisco.Image = ((System.Drawing.Image)(resources.GetObject("btnDisco.Image")));
			this.btnDisco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDisco.Location = new System.Drawing.Point(12, 103);
			this.btnDisco.Name = "btnDisco";
			this.btnDisco.Size = new System.Drawing.Size(154, 85);
			this.btnDisco.TabIndex = 2;
			this.btnDisco.Text = "Disco";
			this.btnDisco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDisco.UseVisualStyleBackColor = true;
			this.btnDisco.Visible = false;
			this.btnDisco.Click += new System.EventHandler(this.btnDisco_Click);
			this.btnDisco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThunderbird_KeyDown);
			this.btnDisco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
			// 
			// btnSistema
			// 
			this.btnSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSistema.Image")));
			this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSistema.Location = new System.Drawing.Point(185, 103);
			this.btnSistema.Name = "btnSistema";
			this.btnSistema.Size = new System.Drawing.Size(154, 85);
			this.btnSistema.TabIndex = 3;
			this.btnSistema.Text = "Sistema";
			this.btnSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSistema.UseVisualStyleBackColor = true;
			this.btnSistema.Visible = false;
			this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
			// 
			// linkRunAsAdmin
			// 
			this.linkRunAsAdmin.AutoSize = true;
			this.linkRunAsAdmin.Location = new System.Drawing.Point(9, 201);
			this.linkRunAsAdmin.Name = "linkRunAsAdmin";
			this.linkRunAsAdmin.Size = new System.Drawing.Size(130, 13);
			this.linkRunAsAdmin.TabIndex = 4;
			this.linkRunAsAdmin.TabStop = true;
			this.linkRunAsAdmin.Text = "Rodar como administrador";
			this.linkRunAsAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRunAsAdmin_LinkClicked);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 232);
			this.Controls.Add(this.linkRunAsAdmin);
			this.Controls.Add(this.btnSistema);
			this.Controls.Add(this.btnDisco);
			this.Controls.Add(this.btnLibreOffice);
			this.Controls.Add(this.btnThunderbird);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Principal";
			this.Text = "Autoatendimento Olvebra";
			this.Load += new System.EventHandler(this.Principal_Load);
			this.Shown += new System.EventHandler(this.Principal_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThunderbird_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThunderbird;
        private System.Windows.Forms.Button btnLibreOffice;
        private System.Windows.Forms.Button btnDisco;
        private System.Windows.Forms.Button btnSistema;
		private System.Windows.Forms.LinkLabel linkRunAsAdmin;
	}
}