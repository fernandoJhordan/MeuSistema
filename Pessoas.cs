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

        public string _nome { get; set; }
        public int _idade { get; set; }

        public Pessoas(string nome, int idade) 
        { 
            _nome=nome;
            _idade=idade;
        }

        public void teste2()
        {
            MessageBox.Show(_nome + " " + _idade);
        }

        public void teste2(int i)
        {
            MessageBox.Show(_nome + " " + i);
        }

        public void teste2(int i, int x)
        {
            int res = i + x;
            MessageBox.Show(_nome + " " + res);
        }
    }
}
