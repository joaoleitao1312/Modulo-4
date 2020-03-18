using System;

namespace Ficha12
{
    public class Ficha12Solucao
    {
        #region Exercicio1

        public static void Exercicio1()
        {
            int acc = 1;
            int count = 0;

            while (count != 3)
            {
                Console.WriteLine("Introduza um número");
                acc *= int.Parse(Console.ReadLine());
                count++;
            }
           
            Console.WriteLine("O produto é " + acc);
        }

        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            Console.WriteLine("Introduz um numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz um numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("+ = " + (num1 + num2));
            Console.WriteLine("- = " + (num1 - num2));
            Console.WriteLine("* = " + (num1 * num2));
            Console.WriteLine("/ = " + (num1 / num2));
            Console.WriteLine("% = " + (num1 % num2));
        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            int x = 0;
            int y = 0;
            int z = 0;
            Console.WriteLine("Introduz um número");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz um número");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz um número");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("(" + x + " + " + y + ")" + " * " + z + " = " + ((x + y) * z));
            Console.WriteLine(x + " * " + y + " + " + y + " * " + z + " = " + (x * y + y * z));


        }

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {

            bool isPrime = true;
            int k = 0;
            Console.WriteLine("What number?");
            k = int.Parse(Console.ReadLine());
            while(k > 1)
            {
                int p = k - 1;
                while (isPrime && p > 1)
                {
                    if (k % p == 0)
                        isPrime = false;
                    p--;
                    
                    
                    
                }
                if (isPrime)
                    Console.WriteLine(k);

                else
                    isPrime = true;

                k--;
            }

        }

        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            Console.WriteLine("Hello?");
            var a = Console.ReadLine();
            if (a == "Is it me you're looking for?")
                Console.WriteLine("I can see it in your eyes");

            else
                Console.WriteLine("Não");
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {
            var item = " ";
            int quantidade = 0;

            Console.WriteLine("Qual o item para dividir");
            item = Console.ReadLine();
            Console.WriteLine("Quantos items para dividir");
            quantidade = int.Parse(Console.ReadLine());

            do
            {
                if (quantidade % 2 == 0)
                {
                    Console.WriteLine("Um " + item + " para mim");
                    quantidade--;
                }
                else
                {
                    Console.WriteLine("Um " + item + " para ti");
                    quantidade--;
                }
            }
            while (quantidade != 0);
        }

        #endregion

        #region Exercicio7

        public static void Exercicio7()
        {
            int ano = 0;
            Console.WriteLine("Insira um ano");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0)            
                Console.WriteLine("O ano " + ano + " é bissexto");
            
            else 
                Console.WriteLine("O ano " + ano + " não é bissexto");
        }

        #endregion

        #region Exercicio8

        public static void Exercicio8 ()
        {
            int beer = 99;

            while (beer != 0)
            {
                Console.WriteLine(beer + " bottles of beer on the wall, " + beer + " bottles of beer.\n" +
                                  "Take one down and pass it around, " + (beer = beer - 1) + " bottles of beer on the wall.");
            }

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.\n " +
                              "Go to the store and buy some more, 99 bottles of beer on the wall.");
        }

        #endregion

        #region Exercicio9

        public static void Exercicio9 ()
        {
            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;

            Console.Write("Escreva o 1º lado do triangulo: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º lado do triangulo: ");
            lado2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 3º lado do triangulo: ");
            lado3 = int.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
                Console.WriteLine("Este triangulo é equilatero");

            else if (lado1 == lado2 && lado2 != lado3 || lado1 == lado3 && lado2 != lado3 || lado3 == lado2 && lado1 != lado3)
                Console.WriteLine("Este triangulo é isosceles");

            else
                Console.WriteLine("Este triagulo é escaleno");            
        }

        #endregion

        #region Exercicio10

        public static void Exercicio10()
        {
            int valor1 = 0;
            int valor2 = 0;
            Console.Write("Insira um valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Insira um valor: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 - valor2 < 0)
            {
                Console.ForegroundColor
                        = ConsoleColor.DarkRed;
                Console.WriteLine("Prejuizo!!!");
                Console.ForegroundColor
                    = ConsoleColor.White;
            }

            if (valor1 - valor2 > 0)
            {
                Console.ForegroundColor
                        = ConsoleColor.Green;
                Console.WriteLine("Lucro!!! Festa hoje em tua casa");
                Console.ForegroundColor
                    = ConsoleColor.White;
            }

            if (valor1 - valor2 == 0)
            {
                Console.ForegroundColor
                        = ConsoleColor.Blue;
                Console.WriteLine("Não perdeste nem ganhaste dinheiro");
                Console.ForegroundColor
                    = ConsoleColor.White;
            }
        }
        #endregion

        #region Exercicio11

        public static void Exercicio11()
        {
            var mes = " ";            
            Console.Write("Insere o més: ");
            int mesPedido = int.Parse(Console.ReadLine());
            
            switch (mesPedido) 
            {
                case 1:
                    
                    mes = "Janeiro - 31 dias";                    
                    Console.WriteLine(mes);
                    break;

                case 2:

                    mes = "Fevereiro - 28 / 29 dias";
                    Console.WriteLine(mes);
                    break;

                case 3:
                    mes = "Março - 31 dias";
                    Console.WriteLine(mes);
                    break;

                case 4:
                    mes = "Abril - 30 dias";
                    Console.WriteLine(mes);
                    break;

                case 5:
                    mes = "Maio - 31 dias";
                    Console.WriteLine(mes);
                    break;

                case 6:
                    mes = "Junho - 30 dias";
                    Console.WriteLine(mes);
                    break;

                case 7:
                    mes = "Julho - 31 dias";
                    Console.WriteLine(mes);
                    break;

                case 8:
                    mes = "Agosto - 31 dias";
                    Console.WriteLine(mes);
                    break;

                case 9:
                    mes = "Setembro - 30 dias";
                    Console.WriteLine(mes);
                    break;

                case 10:
                    mes = "Outubro - 31 dias";
                    Console.WriteLine(mes);
                    break;

                case 11:
                    mes = "Novembro - 30 dias";
                    Console.WriteLine(mes);
                    break;

                case 12:
                    mes = "Dezembro - 31 dias";
                    Console.WriteLine(mes);
                    break;
            }
                
        }

        #endregion

        #region Exercicio12

        public static void Exercicio12() //Não completo
        {
            int n = 0;
            int i = 1;
            int a = 0;
            int b = 0;
            Console.WriteLine("Qual a dimensão da arvore");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                n--;
                while (a != n)
                {
                    Console.WriteLine("*");
                    for (b = 0; b != i; b++)
                    {
                        Console.Write(" ");
                    }
                    a++;
                }

                i += 2;
                Console.Write("\n");
            }

        }

        #endregion

        #region Exercicio 13

        public static void Exercicio13()
        {
            double regA = 2.00;
            double regB = 1.20;
            double regC = 1.00;
            double regD = 0.75;
            double aguaConsumida = 0.00;
            char regiaoEscolhida = ' ';
            bool continuar = true;

            Console.Write("Insira a quantidade de água consumida: ");
            aguaConsumida = double.Parse(Console.ReadLine());
            Console.Write("Insira a sua região(A, B, C ou D): ");
            regiaoEscolhida = char.Parse(Console.ReadLine());

            switch (regiaoEscolhida)
                {
                    case 'A':
                        Console.WriteLine("Total: " + (regA * aguaConsumida));
                        continuar = false;
                        break;

                    case 'B':
                        Console.WriteLine("Total: " + (regB * aguaConsumida));
                        continuar = false;
                        break;

                    case 'C':
                        Console.WriteLine("Total: " + (regC * aguaConsumida));
                        continuar = false;
                        break;

                    case 'D':
                        Console.WriteLine("Total: " + (regD * aguaConsumida));
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Insira uma região válida");
                        continuar = true;
                        break;
                }
        }

        #endregion

        #region Exercicio 14

        public static void Exercicio14()
        {
            int lastNumber = 0;
            int realNumber = 1;
            int fibonacci;
            int n = 0;

            Console.Write("Insira o limite de números para a sequencia de fibonacci: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                fibonacci = lastNumber + realNumber;
                Console.WriteLine(fibonacci);
                lastNumber = realNumber;
                realNumber = fibonacci;
            }
        }

        #endregion

        #region CalcularFibonacci

        private static void CalcularFibonacci()
        {
            int lastNumber = 0;
            int realNumber = 1;
            int fibonacci;
            int n = 0;

            Console.Write("Insira o limite de números para a sequencia de fibonacci: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                fibonacci = lastNumber + realNumber;
                Console.WriteLine(fibonacci);
                lastNumber = realNumber;
                realNumber = fibonacci;
            }
        }

        #endregion

        #region Exercicio15

        public static void Exercicio15()
        {
            int lastNumber = 0;
            int realNumber = 1;
            int fibonacci;
            int n = 0;

            Console.Write("Insira o limite de números para a sequencia de fibonacci: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                fibonacci = lastNumber + realNumber;
                Console.WriteLine(fibonacci);
                lastNumber = realNumber;
                realNumber = fibonacci;
            }
        }

        #endregion

        #region Exercicio16

        public static void Exercicio16()
        {
            int limiteTeto = 100;
            int limiteChao = 1;
            var acertei = false;            
            Console.WriteLine("Pense num numero entre 1 e 100");
            do
            {
                var meio = (limiteTeto - limiteChao) / 2 + limiteChao;
                
                if (meio == (limiteTeto - 1))
                {
                    Console.WriteLine("A resposta é " + meio + "? (s/n)");
                    var resposta = Console.ReadLine();
                    if (resposta == "s")
                    {
                        acertei = true;
                        Console.WriteLine("Acertei");
                    }
                    else if (resposta == "n")
                    {
                        Console.WriteLine("A resposta é " + (meio + 1) + "?");
                        resposta = Console.ReadLine();
                        if (resposta == "s")
                        {
                            acertei = true;
                            Console.WriteLine("Acertei");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O número é maior que " + meio + "? (s/n)");
                    var resposta = Console.ReadLine();
                    if (resposta == "s")
                        limiteChao = meio + 1;
                    else if (resposta == "n")
                        limiteTeto = meio - 1;
                }                

            }
            while (!acertei);
            
            


        }
        
        #endregion
    }
}
 