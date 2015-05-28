using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Exercicio_02_00
{
    public class Compra
    {
        public double Valor { get; set; }
        public double getValorDaParcela() { 
            return Valor / 5;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }       
    }
}
