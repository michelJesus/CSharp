using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace WFAppAps
{
    class ContextoDeDados : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Credito> Creditos { get; set; }
        public DbSet<Debito> Debitos { get; set; }
    }
}
