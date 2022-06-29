using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_PAG35
{
    public class CalcPrecoProd
    {
        public double CalcPrecoTOT(double preco, int quantidade)
        {
            double precoTotal;
            precoTotal = (quantidade * preco);
            return precoTotal;
        }
    }
}
