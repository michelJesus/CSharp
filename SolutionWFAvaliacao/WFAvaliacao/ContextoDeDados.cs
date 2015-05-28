using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace WFAvaliacao
{
    class ContextoDeDados : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
    }
}
