using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationApsFinal
{
    public class Despesa
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public String Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
