using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAppAps
{
    class Conta
    {

        public Conta() 
        {
            Pessoa newPessoa = new Pessoa();
            Credito newCredito = new Credito();
            Debito newDebito = new Debito();
        }

        public int ContaId { get; set; }
        public DateTime DataConta { get; set; }
        public String TipoConta { get; set; }

        public int Saldo { get; set; }

        public Pessoa Pessoa { get; set; }
        public Credito Credito { get; set; }
        public Debito Debito { get; set; }


        public void Debitar(int valorDeb) 
        {
            
            Saldo = Saldo - valorDeb;
        }

        private void Creditar(int valorCre)
        {
            Saldo = Saldo + valorCre;
        }

    }
}
