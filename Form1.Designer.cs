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
            this.lblParcela1 = new System.Windows.Forms.Label();
            this.txtParcela1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblParcela2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtParcela2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblParcela1
            // 
            this.lblParcela1.AutoSize = true;
            this.lblParcela1.Location = new System.Drawing.Point(60, 48);
            this.lblParcela1.Name = "lblParcela1";
            this.lblParcela1.Size = new System.Drawing.Size(64, 16);
            this.lblParcela1.TabIndex = 0;
            this.lblParcela1.Text = "Parcela 1";
            // 
            // txtParcela1
            // 
            this.txtParcela1.Location = new System.Drawing.Point(130, 48);
            this.txtParcela1.Name = "txtParcela1";
            this.txtParcela1.Size = new System.Drawing.Size(213, 22);
            this.txtParcela1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(360, 125);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblParcela2
            // 
            this.lblParcela2.AutoSize = true;
            this.lblParcela2.Location = new System.Drawing.Point(60, 92);
            this.lblParcela2.Name = "lblParcela2";
            this.lblParcela2.Size = new System.Drawing.Size(64, 16);
            this.lblParcela2.TabIndex = 3;
            this.lblParcela2.Text = "Parcela 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(60, 125);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // txtParcela2
            // 
            this.txtParcela2.Location = new System.Drawing.Point(130, 86);
            this.txtParcela2.Name = "txtParcela2";
            this.txtParcela2.Size = new System.Drawing.Size(213, 22);
            this.txtParcela2.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(130, 122);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(213, 22);
            this.txtResultado.TabIndex = 6;
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 296);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtParcela2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblParcela2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtParcela1);
            this.Controls.Add(this.lblParcela1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "FrmMeuSistema";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParcela1;
        private System.Windows.Forms.TextBox txtParcela1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblParcela2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtParcela2;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

