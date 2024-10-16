using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema
{
    public partial class FrmMeuSistema : Form
    {
        //Operadores
        float nota1, nota2, nota3, nota4, media;

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            
            txtRes.Text = Convert.ToString(media);
            
            //condição IF
            if (media >= 6)
            {
                lblRes.Text = "APROVADO";
            }
            else {
                lblRes.Text = "REPROVADO";
            }

        }
    }
}
