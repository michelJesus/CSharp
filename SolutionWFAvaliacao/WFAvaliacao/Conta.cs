using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAvaliacao
{
    class Conta
    {
        public int Id { get; set; }

        public DateTime DataDeAbertura { get; set; }

        public String Identificacao { get; set; }

        public String Correntista { get; set; }

        public double Saldo { get; set; }
    }
}
