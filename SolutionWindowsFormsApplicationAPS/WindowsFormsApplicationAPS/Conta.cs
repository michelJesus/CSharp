using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationAPS
{
    public class Conta
    {
        public Conta() {
            Pessoa = new Pessoa();
            Credito = new Credito();
            Debito = new Debito();
        }
        public int Id { get; set; }
        public DateTime DataDaConta { get; set; }
        public String TipoDaConta { get; set; }
        public decimal Saldo { get; set; }

        public Credito Credito { get; set; }

        public Debito Debito { get; set; }

        public Pessoa Pessoa { get; set; }

        public void Debitar(decimal valor)
        {
            Saldo = Saldo - valor;
        }

        public void Creditar(decimal valor)
        {
            Saldo = Saldo + valor;
        }   
    }
}
