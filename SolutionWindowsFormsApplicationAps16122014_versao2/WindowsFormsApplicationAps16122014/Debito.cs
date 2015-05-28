using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAps16122014
{
    public class Debito
    {
        public int DebitoId { get; set; }
        public DateTime DataDebito { get; set; }
        public decimal ValorDebito { get; set; }

        public Conta Conta { get; set; }
    }
}
