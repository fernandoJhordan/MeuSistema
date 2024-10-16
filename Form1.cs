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
        //Array

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Array

            int[] valores= new int[] { 10, 20, 30, 40, 50, 60, 70};

            for (int i = 0; i < valores.Length; i++)
            {
                lista.Items.Add(valores[i]);
            }
            

        }
    }
}
