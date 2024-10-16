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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.resSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(60, 48);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(49, 16);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(115, 48);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(66, 22);
            this.txtNota1.TabIndex = 1;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(187, 221);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(68, 23);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "OK";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(60, 81);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(49, 16);
            this.lblNota2.TabIndex = 3;
            this.lblNota2.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(115, 78);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(66, 22);
            this.txtNota2.TabIndex = 4;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(60, 110);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(49, 16);
            this.lblNota3.TabIndex = 5;
            this.lblNota3.Text = "Nota 3:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(115, 107);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(66, 22);
            this.txtNota3.TabIndex = 6;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(115, 135);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(66, 22);
            this.txtNota4.TabIndex = 7;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(60, 138);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(49, 16);
            this.lblNota4.TabIndex = 8;
            this.lblNota4.Text = "Nota 4:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(37, 225);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(72, 16);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "Resultado:";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(115, 222);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(66, 22);
            this.txtRes.TabIndex = 10;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(43, 277);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(63, 16);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.Text = "Situação:";
            // 
            // resSituacao
            // 
            this.resSituacao.AutoSize = true;
            this.resSituacao.Location = new System.Drawing.Point(112, 277);
            this.resSituacao.Name = "resSituacao";
            this.resSituacao.Size = new System.Drawing.Size(0, 16);
            this.resSituacao.TabIndex = 12;
            // 
            // FrmMeuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 311);
            this.Controls.Add(this.resSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "FrmMeuSistema";
            this.Text = "Aplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label resSituacao;
    }
}

