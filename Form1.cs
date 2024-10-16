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
        //Switch
        int valor;

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            valor=int.Parse(txtValor.Text);

            //Switch
            //switch (valor)
            //{
            //    case 10: //caso for 10 -> 1° opcao
            //        lblRes.Text = "É 10";
            //        //instruções
            //        break;
            //    case 11:
            //        lblRes.Text = "É 11";
            //        break;
            //    case 50:
            //        lblRes.Text = "É 50";
            //        break;
            //    default:
            //        lblRes.Text = "Não foi encontrado...";
            //        break;
            //}

            //Ternario
            lblRes.Text = valor == 10 ? "SIMMMM" : "NÃAAAAO";

        }
    }
}
