using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAPS
{
    public class Credito
    {
        public int CreditoId { get; set; }
        public DateTime DataCredito { get; set; }
        public String DescricaoCredito { get; set; }
        public decimal valorCredito { get; set; }
    }
}
