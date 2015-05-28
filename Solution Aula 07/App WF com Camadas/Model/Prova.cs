using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Prova
    {

        public double Nota { get; set; }

        // public double Nota;

       // public double Nota { get; set; }


        /*
        
        private double nota;

        
        public double Nota
        {
            get { return nota; }
            set {
                if (value < 0 || value > 10)
                {
                    throw new Exception("Nota inválida!");
                } 
                nota = value;
            }
        }
         * /
        

        /*
        public void setNota(double nota)
        {
            if (nota < 0 || nota > 10)
            {
                throw new Exception("Nota inválida!");
            }
            this.Nota = nota;
        }

        public double getNota()
        {
            return Nota;
        }
         * 
         * */
    }
}
