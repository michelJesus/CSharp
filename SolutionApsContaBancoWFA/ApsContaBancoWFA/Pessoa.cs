using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsContaBancoWFA
{
    class Pessoa
    {
        public int Id { get; set; }
        
        public DateTime DataDeCadastro { get; set; }
        
        public String Nome { get; set; }

        public String Endereco { get; set; }

        public int Cpf { get; set; }
    }
}
