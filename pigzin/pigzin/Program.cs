using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigzin
{
    class Program
    {
        static void Main(string[] args)
        {

            Cofrinho cof = new Cofrinho();
            Moeda cincoCentavos = new Moeda(0.05, "centavos");
            Moeda dezCentavos = new Moeda(0.10, "centavos");
            Moeda vinteCinco = new Moeda(0.25, "centavos");
            Moeda ciquentaCetavos = new Moeda(0.50, "centavos");
            Moeda umReal = new Moeda(1, "real");

            cof.Adicionar(cincoCentavos);
            cof.Adicionar(dezCentavos);
            cof.Adicionar(vinteCinco);
            cof.Adicionar(ciquentaCetavos);
            cof.Adicionar(umReal);



            Console.WriteLine(Cofrinho.QuantMoedasDeterminadoValor("5,76"));
            Console.WriteLine("Você tem R$" + cof.CalcularTotal() + " Reais");
            Console.WriteLine("Você tem " + cof.QuantMoedas() + " moeda(s)");
            Console.WriteLine("Você tem " + cof.Moedin[0] + " moeda(s) de 5 centavos");
            Console.WriteLine("Você tem " + cof.Moedin[1] + " moeda(s) de 10 centavos");
            Console.WriteLine("Você tem " + cof.Moedin[2] + " moeda(s) de 25 centavos");
            Console.WriteLine("Você tem " + cof.Moedin[3] + " moeda(s) de 50 centavos");
            Console.WriteLine("Você tem " + cof.Moedin[4] + " moeda(s) de 1 Real");


            Console.ReadKey();

        }
    }
}
