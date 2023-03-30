using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigzin
{
    class Cofrinho
    {

        int[] moedin = new int[5];

        public int[] Moedin { get => moedin; set => moedin = value; }

        public void Adicionar(Moeda m)
        {
            if (m.Valor == 0.05)
            {
                Moedin[0] += 1;
            }
            else
            {
                if (m.Valor == 0.10)
                {
                    Moedin[1] += 1;
                }
                else
                {
                    if (m.Valor == 0.25)
                    {
                        Moedin[2] += 1;
                    }
                    else
                    {
                        if (m.Valor == 0.50)
                        {
                            Moedin[3] += 1;
                        }
                        else
                        {
                            if (m.Valor == 1)
                            {
                                Moedin[4] += 1;
                            }
                        }
                    }
                }
            }
        }

        public int QuantMoedas()
        {
            int qnt = 0;

            for (int i = 0; i < Moedin.Length; i++)
            {
                qnt += Moedin[i];
            }

            return qnt;

        }

        public double CalcularTotal()
        {
            double total = 0;

                total += Moedin[0] * 0.05;
                total += Moedin[1] * 0.10;
                total += Moedin[2] * 0.25;
                total += Moedin[3] * 0.50;
                total += Moedin[4] * 1;


            return total;

        }

        public static string QuantMoedasDeterminadoValor(string valor)
        {
            double numero;

            int[] carteira = new int[5];


            Double.TryParse(valor, out numero);

            

            for (int i = 0; i < numero; i++)
            {
                if (numero >= 1)
                {
                    numero = numero - 1;
                    carteira[4] += 1;
                    i--;
                }
                else
                {
                    if (numero >= 0.50)
                    {
                        numero = numero - 0.50;
                        carteira[3] += 1;
                        i--;
                    }
                    else
                    {
                        if (numero >= 0.25)
                        {
                            numero = numero - 0.25;
                            carteira[2] += 1;
                            i--;
                        }
                        else
                        {
                            if (numero >= 0.10 || numero >= 0.09)
                            {
                                numero = numero - 0.10;
                                carteira[1] += 1;
                                i--;
                            }
                            else
                            {
                                if (numero <= 0.05)
                                {
                                    numero = numero - 0.05;
                                    carteira[0] += 1;
                                    i--;
                                }


                            }
                        }
                    }
                }

            }

            return "1 real: " + carteira[4] + " || 50 centavos: " + carteira[3] + " || 25 centavos: " + carteira[2] + " || 10 centavos: " + carteira[1] + " || 5 centavos: " + carteira[0];

        }



        ~Cofrinho() { }

        
    }
}
