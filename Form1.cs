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
        //foreach

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string frase = "Meu curso de C# na Zatec Cursos.";
            foreach (char f in frase)
            {
                lista.Items.Add(f);
            }

        }
    }
}
