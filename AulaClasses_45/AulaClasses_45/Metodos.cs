using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasses_45
{
    public class Metodos
    {
        public double n1 { get; set; }
        public double n2 { get; set; }

        public double n3 { get; set; }

        public double soma3numeros()
        {
            return n1 + n2 + n3;
        }


        public double calcMedia()
        {
            return n1 + n2 + n3 / 3;
        }

        public double maiorN()
        {
            double[] listaNum = { n1, + n2, n3 };
            return listaNum.Max();
        }

        public double menorN()
        {
            double[] listaNum = { n1, n2, n3 };
            return listaNum.Min();
        }

        public double cuboNum()
        {
            return Math.Pow(n1, 3);
        }

        public string parImpar()
        {
            if (n1 % 2 == 0)
            {
                return "par";
            }

            else
            {
                return "numero impar !";
            }
        }

        public string POSINEGA()
        {
            if (n1 >= 1)
            {
                return "Positivo";
            }

           else if (n1 <= -1)
            {
                return "Negativo";
            }

            else
            {
                return null;
            }
        }
    }
}
