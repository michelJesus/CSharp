using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace ApsContaBancoWFA
{
    class ContextoDeDados : DbContext
    {
        public DbSet<Pessoa> CadastroDePessoas { get; set; }
        public DbSet<Despesa> CadastroDeDespesas { get; set; }
        public DbSet<Receita> CadastroDeReceitas { get; set; }
    }
}
