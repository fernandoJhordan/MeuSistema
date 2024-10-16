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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(93, 59);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 16);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(62, 87);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 22);
            this.txtValor.TabIndex = 1;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(63, 141);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(118, 23);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "OK";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(93, 177);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(16, 16);
            this.lblRes.TabIndex = 11;
            this.lblRes.Text = "...";
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 311);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "FrmMeuSistema";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblRes;
    }
}

