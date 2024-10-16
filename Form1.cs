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
        //While // Do While

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = 1;
            //while (n <= 30) 
            //{
            //    lista.Items.Add(n);
            //    n++;
            //}

            do
            {
                lista.Items.Add(n++);
            } while (n <= 100);



        }
    }
}
