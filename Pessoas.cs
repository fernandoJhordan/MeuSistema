using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema
{
    class Pessoas
    {
        public string Nome;
        public int Idade;
        public double Altura;
        public string Nacionalidade;

        //metodo
        public void falar() 
        {
            MessageBox.Show("Olá! sou " + Nome + " e tenho " + Idade + " anos.");
        }

    }
}
