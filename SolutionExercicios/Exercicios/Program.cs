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
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 1");
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
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 2");
            int numero1 = 5;
            int numero2 = 10;
            //int resultado = numero1 + numero2;
            Console.WriteLine("Resultado: " + (numero1 + numero2));
            //Resultado: + 5 = Resultado: 5
            //Resultado: 5 + 10 = Resultado: 510


            // Exercício 3
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 3");
            string valor = Console.ReadLine();
            Console.WriteLine(valor);


            // Exercício 4
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 4");
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
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 5");
            int vA = 10;
            int vB = 20;
            int vC = 0;
            vC = vA;
            vA = vB;
            vB = vC;
            Console.WriteLine("VA: " + vA + " VB: " + vB);

            // Exercício 6
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 6");
            Console.Write("Informe número 1: ");
            string n = Console.ReadLine();
            double c = Convert.ToInt16(c1);
            double f = (9 * c + 160) / 5;
            Console.WriteLine("Temperatura em Fahrenheit: " + f);

            // Exercício 7
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 7");
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
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 8");
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
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 9");
            int[] numeros = { 2, -2, 0 };
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine("Positivo: " + numeros[i]);
                }
                else if (numeros[i] < 0)
                {
                    Console.WriteLine("Negativo: " + numeros[i]);
                }
                else
                {
                    Console.WriteLine("Zero: " + numeros[i]);
                }
            }

            // Exercício 10
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 10");
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
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 11");
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

            
            // Exercício 12
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 12");
            int[] arrayN = { 3, 1, 2 };
            int aux = 0;

            for (int i = 0; i < arrayN.Length; i++)
            {
                for (int j = 0; j < arrayN.Length - 1; j++)
                {
                    if (arrayN[j] > arrayN[j + 1])
                    {
                        aux = arrayN[j + 1];
                        arrayN[j + 1] = arrayN[j];
                        arrayN[j] = aux;
                    }
                }
            }

            for (int i = 0; i < arrayN.Length; i++)
            {
                Console.WriteLine(arrayN[i]);
            }
            

            // Exercício 13
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Exercicio 13");
                        
             int jan = 1;
             int fev = 2;
             int mar = 3;
             int abr = 4;
             int mai = 5;
             int jun = 6;
             int jul = 7;
             int ago = 8;
             int set = 9;
             int outu = 10;
             int nov = 11;
             int dez = 12;

             Console.WriteLine("Informe o mês (sendo de 1 à 12): ");
             string mes = Console.ReadLine();

             int mesConv = Convert.ToInt16(mes);

             if (mesConv == jan)
             {
                  Console.WriteLine("Janeiro");
             }
             else if (mesConv == fev)
             {
                  Console.WriteLine("Fevereiro");
             }
             else if (mesConv == mar)
             {
                  Console.WriteLine("Março");
             }
             else if (mesConv == abr)
             {
                  Console.WriteLine("Abril");
             }
             else if (mesConv == mai)
             {
                  Console.WriteLine("Maio");
             }
             else if (mesConv == jun)
             {
                  Console.WriteLine("Junho");
             }
             else if (mesConv == jul)
             {
                  Console.WriteLine("Julho");
             }
             else if (mesConv == ago)
             {
                  Console.WriteLine("Agosto");
             }
             else if (mesConv == set)
             {
                  Console.WriteLine("Setembro");
             }
             else if (mesConv == outu)
             {
                  Console.WriteLine("Outubro");
             }
             else if (mesConv == nov)
             {
                  Console.WriteLine("Novembro");
             }
             else if (mesConv == dez)
             {
                  Console.WriteLine("Dezembro");
             }
             else if (mesConv < 0 && mesConv > 12)
             {
                  Console.WriteLine("Inválido");
             }
                     

            // Exercício 14
             Console.WriteLine("");
             Console.WriteLine("---------");
             Console.WriteLine("Exercicio 14");
             int resultado;

            Console.Write("Informe primeiro número: ");
            string a14 = Console.ReadLine();
            int a14C = Convert.ToInt16(a14);
            
            Console.WriteLine("Informe a operação desejada (+ - * /): ");
            string operacao = Console.ReadLine();
            char op = Convert.ToChar(operacao);

            Console.Write("Informe segundo número: ");
            string b14 = Console.ReadLine();
            int b14C = Convert.ToInt16(b14);

            switch (op)
            {
                case '+': resultado = a14C + b14C;
                    Console.WriteLine(resultado);
                    break;

                case '-': resultado = a14C - b14C;
                    Console.WriteLine(resultado);
                    break;

                case '*': resultado = a14C * b14C;
                    Console.WriteLine(resultado);
                    break;

                case '/':
                    try
                    {
                        resultado = a14C / b14C;
                    }
                    catch (System.DivideByZeroException)
                    {
                        
                        System.Console.WriteLine("Indefinido");
                    }
                    resultado = a14C / b14C;
                    Console.WriteLine(resultado);
                    break;

                default:
                    Console.WriteLine("Operador inválida");
                    break;
            } 
            Console.ReadLine();
        }
    }
}
