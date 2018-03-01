namespace SuporteSolution.Telas.Disco
{
    partial class LimparDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimparDisco));
            this.label4 = new System.Windows.Forms.Label();
            this.cbDiscoOrigem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Atenção: Essa rotina removerá os dados do disco selecionado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbDiscoOrigem
            // 
            this.cbDiscoOrigem.FormattingEnabled = true;
            this.cbDiscoOrigem.Location = new System.Drawing.Point(12, 72);
            this.cbDiscoOrigem.Name = "cbDiscoOrigem";
            this.cbDiscoOrigem.Size = new System.Drawing.Size(260, 21);
            this.cbDiscoOrigem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o disco:";
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Location = new System.Drawing.Point(18, 222);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(252, 23);
            this.btnOpcoes.TabIndex = 10;
            this.btnOpcoes.Text = "Opções Avançadas >>";
            this.btnOpcoes.UseVisualStyleBackColor = true;
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparDados.Image")));
            this.btnLimparDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparDados.Location = new System.Drawing.Point(63, 112);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(154, 85);
            this.btnLimparDados.TabIndex = 9;
            this.btnLimparDados.Text = "Limpar Dados";
            this.btnLimparDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // LimparDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOpcoes);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDiscoOrigem);
            this.Controls.Add(this.label4);
            this.MinimizeBox = false;
            this.Name = "LimparDisco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.LimparDisco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDiscoOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnLimparDados;
    }
}