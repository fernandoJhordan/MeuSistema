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
        //modificador // tipo  // texto
        public string meuNome;
        private int valor;
        protected String senha;

        //mais usados
        int numeros = 0;
        string endereco;
        bool estaPago;
        double valores;
        decimal vPago;



        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            meuNome=txtDigite.Text;
            txtDigite.Text="";
            txtFrase.Text = meuNome;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
