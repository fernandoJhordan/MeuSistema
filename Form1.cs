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
        //Conversão e Operadores aritméticos
        //int valor1;
        //int valor2;
        //int res;

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtParcela1.Text);
            int valor2 = int.Parse(txtParcela2.Text);
            // + , - , * , / , %
            //res = valor1+valor2;
            //res = valor1 - valor2;
            //res = valor1 * valor2;
            int res = valor1 % valor2;
            txtResultado.Text=Convert.ToString(res);
        }
    }
}
