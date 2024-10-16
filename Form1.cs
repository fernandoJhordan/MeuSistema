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
            Pessoas p1 = new Pessoas();

            p1.Nome = "Fernando Michael";
            p1.Idade = 28;
            p1.Altura = 1.67;
            p1.Nacionalidade = "PT";

            p1.falar();
        }

    }
}
