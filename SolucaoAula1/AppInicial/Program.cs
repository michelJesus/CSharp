using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * TIPOS PRIMITIVOS
               int
               boolean
               double
               float
               char
               long
             
             * CLASSES
               objetos
            
             * Exemplos
                int a = 5;
                int b = 10;
                long c = 100;
                double d = 15.6;
                float e = 11.6F;
                decimal f = 55.9M;

                bool isValido = false;

                char caractere = 'A';
                string texto = "Vários caracteres";
             */

            int valor1 = 10;
            int valor2 = 20;

            // Soma
            int resultado1 = valor1 + valor2;

            // Subtração
            int resultado2 = valor1 - valor2;

            // Multiplicação
            int resultado3 = valor1 * valor2;

            // Divisão
            int resultado4 = valor1 / valor2;

            Console.WriteLine("Soma: " + resultado1);
            Console.WriteLine("Subtração: " + resultado2);
            Console.WriteLine("Maultiplicação: " + resultado3);
            Console.WriteLine("Divisão: " + resultado4);

            // Exercício 1
            int numero = 7;
            if (numero > 10)
            {
                Console.WriteLine("É maior do que 10");
            }
            else
            {
                Console.WriteLine("É menor do que 10");
            }


            // Exercício 2
            int numero1 = 5;
            int numero2 = 10;
            Console.WriteLine("Resultado: {0}{1}", numero1 + numero2, 5);


            // Exercício 3
            string valor = Console.ReadLine();
            Console.WriteLine(valor);
            

            // Exercício 4
            Console.Write("Informe número 1: ");
            string v1 = Console.ReadLine();

            Console.Write("Informe número 2: ");
            string v2 = Console.ReadLine();

            int c1 = Convert.ToInt16(v1);
            int c2 = Convert.ToInt16(v2);
            int r = c1 + c2;
            Console.Write("Resultado: ");
            Console.WriteLine(r);

            // Exercício 5
            int vA = 10;
            int vB = 20;
            int vC = 0;
            vC = vA;
            vA = vB;
            vB = vC;
            Console.WriteLine("VA: " + vA + " VB: " + vB);

            // Exercício 6
            Console.Write("Informe número 1: ");
            string n = Console.ReadLine();
            double c = Convert.ToInt16(c1);
            double f = (9 * c + 160) / 5;
            Console.WriteLine("Temperatura em Fahrenheit: " + f);

            // Exercício 7
            Console.Write("Informe um número: ");
            string num = Console.ReadLine();
            int num1 = Convert.ToInt16(num);
            if (num1 < 100 || num1 > 200)
            {
                Console.WriteLine("O número digitado não está entre 100 e 200");
            }
            else
            {
                Console.WriteLine("O número está entre 100 e 200");
            }

            // Exercício 8
            Console.Write("Informe um número: ");
            string numeroI = Console.ReadLine();
            int numeroC = Convert.ToInt16(numeroI);
            if (numeroC > 50 || numeroC < 10 || numeroC == 20)
            {
                Console.WriteLine("Número é maior que 50, menor que 10 ou igual a 20");
            }
            else
            {
                Console.WriteLine("Número não é maior que 50, menor que 10 ou igual a 20");
            }
            
            // Exercício 9
            int[] numeros = {2, -2, 0};
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine("Positivo: " + numeros[i]);
                } else if (numeros[i] < 0) {
                    Console.WriteLine("Negativo: " + numeros[i]);
                }
                else
                {
                    Console.WriteLine("Zero: " + numeros[i]);
                }
            }

            // Exercício 10
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            
            Console.WriteLine("Informe um número: ");
            string numero10 = Console.ReadLine();
            int numero11 = Convert.ToInt16(numero10);
            if (array[0] == numero11)
            {
                Console.WriteLine("Um");
            }
            else if (array[1] == numero11)
            {
                Console.WriteLine("Dois");
            }
            else if (array[2] == numero11)
            {
                Console.WriteLine("Três");
            }
            else if (array[3] == numero11)
            {
                Console.WriteLine("Quatro");
            }
            else if (array[4] == numero11)
            {
                Console.WriteLine("Cinco");
            }
            else
            {
                Console.WriteLine("Inválido");
            }

            // Exercício 11
            Console.WriteLine("Informe um número: ");
            string num01 = Console.ReadLine();
            int num02 = Convert.ToInt16(num01);
            
            Console.WriteLine("Informe um número: ");
            string num03 = Console.ReadLine();
            int num04 = Convert.ToInt16(num03);

            if (num02 == num04)
            {
                Console.WriteLine("Números iguais");
            }
            else if (num02 < num04)
            {
                Console.WriteLine("Números diferentes e o maior é: " + num04);
            }
            else if (num02 > num04) 
            {
                Console.WriteLine("Números diferentes e o maior é: " + num02);
            }




                Console.ReadLine();

        }
    }
}
