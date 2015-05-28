using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAps16122014
{
    public class Credito
    {
        public int CreditoId { get; set; }
        public DateTime DataCredito { get; set; }
        public decimal ValorCredito { get; set; }
        public Conta Conta { get; set; }
    }
}
