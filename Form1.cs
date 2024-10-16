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
        //foreach p2

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Foreach parte2
            List<string> lista_nomes = new List<string>()
            {
                "Leo", "José", "Alex", "Maria", "João", "Marcia"
            };

            foreach (string ls in lista_nomes)
            {
                lista.Items.Add(ls);
            }

        }
    }
}
