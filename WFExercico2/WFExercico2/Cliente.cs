using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFExercico2
{
    class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public double ValorCompra { get; set; }
        public double ValorParcela { get; set; }

        public double DivisaoParcela() {
            double parc = 0;
            parc = ValorCompra / 5;
            return parc;
        }
    }
}
