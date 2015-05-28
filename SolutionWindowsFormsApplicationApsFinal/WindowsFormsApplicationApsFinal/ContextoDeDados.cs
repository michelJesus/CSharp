using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace WindowsFormsApplicationApsFinal
{
    public class ContextoDeDados : DbContext
    {
        public DbSet <Pessoa> Pessoas { get; set; }
        public DbSet <Despesa> Despesas { get; set; }
        public DbSet <Receita> Receitas { get; set; }
        public DbSet <Conta> Contas { get; set; }
    }
}
