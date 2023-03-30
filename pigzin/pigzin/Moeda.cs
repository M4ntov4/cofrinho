using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigzin
{
    class Moeda
    {
        double valor;
        string nome;

        public double Valor { get => valor; set => valor = value; }
        public string Nome { get => nome; set => nome = value; }

        public Moeda(double v, string n)
        {
            this.Valor = v;
            this.Nome = n;
        }



    }
}
