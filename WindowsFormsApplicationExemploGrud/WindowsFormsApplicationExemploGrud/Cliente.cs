﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationExemploGrud
{
    public class Cliente
    {
        // Obrigatório Id para usar o EntityFramework
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

    }
}
