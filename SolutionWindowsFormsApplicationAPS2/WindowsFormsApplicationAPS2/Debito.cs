using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAPS2
{
    public class Debito
    {
        public int DebitoId { get; set; }
        public DateTime DataDebito { get; set; }
        public String DescricaoDebito { get; set; }
        public int ValorDebito { get; set; }
    }
}
