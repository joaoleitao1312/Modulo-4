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
 