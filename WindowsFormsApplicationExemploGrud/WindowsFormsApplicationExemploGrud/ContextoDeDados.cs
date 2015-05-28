using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Obrigatório
using System.Data.Entity;

namespace WindowsFormsApplicationExemploGrud
{
    // Precisa especializar a classe DbContext
    public class ContextoDeDados : DbContext
    {
        // Declarar as entidades
        public DbSet<Cliente> Clientes { get; set; }
    }
}
