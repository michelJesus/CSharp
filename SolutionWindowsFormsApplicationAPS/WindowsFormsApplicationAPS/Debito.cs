using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAPS
{
    public class Debito
    {
        public int DebitoId { get; set; }
        public DateTime DataDedito { get; set; }
        public String DescricaoDedito { get; set; }
        public decimal valorDedito { get; set; }

    }
}
