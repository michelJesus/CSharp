using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAps16122014
{
    public class Conta
    {

        ContextoDeDados db = new ContextoDeDados();


        public int ContaId { get; set; }
        public DateTime DataConta { get; set; }
        public String TipoConta { get; set; }
        public decimal SaldoConta { get; set; }
                
        public Pessoa Pessoa { get; set; }
    }
}
