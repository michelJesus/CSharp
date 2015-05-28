using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace WFExercico2
{
    class ContextoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
