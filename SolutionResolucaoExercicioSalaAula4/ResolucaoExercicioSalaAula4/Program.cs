using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoExercicioSalaAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercícios de algoritmos estruturados */
            
            //ExecutarExercicio8();

            //ExecutarExercicio9();

            ExecutarExercicio10();

            Console.ReadLine(); // faz uma pausa
        }

        /* 10. Faça um algoritmo que leia um número de 1 a 5 
         * e escreva por extenso. Caso o usuário digite um número 
         * que não esteja neste intervalo, 
         * exibir mensagem: número inválido. */
        private static void ExecutarExercicio10()
        {
            Console.WriteLine("Informe um número: ");
            string s = Console.ReadLine();

            int numeroDigitado = int.Parse(s);
            string[] nomes = { "um", "dois", "três", "quatro", "cinco" };

            //int[] numeros = new int[5];
            int[] numeros = { 1, 2, 3, 4, 5 };

            bool isNumeroValido = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                int valorDaPosicao = numeros[i];
                Console.WriteLine("O número é {0}", nomes);

                if (numeroDigitado == valorDaPosicao)
                {
                    isNumeroValido = true;
                }
            }

            if (!isNumeroValido)
            {
                Console.WriteLine("O número é inválido!");
            }
        }


        /*
         9. Faça um algoritmo que receba "N" números e mostre positivo, 
         * negativo ou zero para cada número.
         */
        private static void ExecutarExercicio9()
        {
 	        bool deveContinuarLeitura = true;

            while (deveContinuarLeitura)
	        {
                Console.WriteLine("Digite o número ou 'N' para sair: ");
                string s = Console.ReadLine();

                if (s == "N")
                {
                    deveContinuarLeitura = false;
                }
                else
                {
                    int numero = int.Parse(s);

                    if (numero > 0)
                    {
                        Console.WriteLine("O número é positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("O número é negativo.");
                    }
                    else
                    {
                        Console.WriteLine("O número é zero.");
                    }
                }
                
                      
	        }
        }


        /* 8. Faça um algoritmo que receba um número 
         * e mostre uma mensagem caso este número seja maior que 50, 
         * menor que 10 ou igual a 20. */
        static void ExecutarExercicio8()
        {
            Console.WriteLine("Informe um número");
            string s = Console.ReadLine();

            int numero = int.Parse(s);

            if (numero > 50)
            {
                Console.WriteLine("O número {0} é maior que 50.", numero);
            }
            else if (numero > 10)
            {
                Console.WriteLine("O número {0} é menor que 10.", numero);
            }
            else if (numero == 20)
            {
                Console.WriteLine("O número {0} é igual a 20.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é inaválido.", numero);
            }
        }

        
    }
}
