namespace MeuSistema
{
    partial class FrmMeuSistema
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtDigite = new System.Windows.Forms.TextBox();
            this.lblDigite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(347, 180);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFrase.Location = new System.Drawing.Point(31, 128);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(391, 22);
            this.txtFrase.TabIndex = 2;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(28, 109);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(72, 16);
            this.lblFrase.TabIndex = 3;
            this.lblFrase.Text = "Resultado:";
            // 
            // txtDigite
            // 
            this.txtDigite.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDigite.Location = new System.Drawing.Point(31, 50);
            this.txtDigite.Name = "txtDigite";
            this.txtDigite.Size = new System.Drawing.Size(391, 22);
            this.txtDigite.TabIndex = 4;
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(28, 31);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(47, 16);
            this.lblDigite.TabIndex = 5;
            this.lblDigite.Text = "Nome:";
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 493);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.txtDigite);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOK);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "FrmMeuSistema";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txtDigite;
        private System.Windows.Forms.Label lblDigite;
    }
}

