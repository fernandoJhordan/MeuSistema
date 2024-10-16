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

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //instancia da classe
            Pessoas p1 = new Pessoas("Fernando",28);

            
            //Overloading... o mesmo método com quantidade de param diferentes
            p1.teste2();
            p1.teste2(5);
            p1.teste2(5,9);


        }

    }
}
