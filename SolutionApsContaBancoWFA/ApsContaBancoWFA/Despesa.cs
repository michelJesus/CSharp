using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsContaBancoWFA
{
    class Despesa
    {
        public int Id { get; set; }
                
        public DateTime DataDaDespesa { get; set; }
        
        public String DescricaoDaDespesa { get; set; }
       
        public decimal ValorDaDespesa { get; set; }
    }
}
