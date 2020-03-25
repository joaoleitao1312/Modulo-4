using System;

namespace Ficha14
{
    public class Ficha14Solucao
    {
        #region Exercicio1

        public static void Exercicio1()
        {
            int n = 0;

            Console.WriteLine("Insira um número limite");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            int n = 0;
            int i = 0;

            Console.WriteLine("Insira um número limite");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i < n; i++)
            {               
            }

            do
            {
                int a = i--;
                Console.WriteLine(a);
            }
            while (i != 0);


        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            int n = 0;
            int i = 0;
            int acc = 0;

            Console.WriteLine("Insira um número limite");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                acc += i;
            }

            Console.WriteLine(acc);

            

        }

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            int num1 = 0;
            int num2 = 0;
            int i = 0;

            Console.WriteLine("Insira um número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um número");
            num2 = int.Parse(Console.ReadLine());

            for (i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        #endregion

        #region Exercicio5
        
        public static void Exercicio5()
        {
            int lastNumber = 0;
                int realNumber = 1;
                int fibonacci = 0;
                int n = 0;

                Console.Write("Insira o limite de números para a sequencia de fibonacci: ");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(fibonacci);
                    fibonacci = lastNumber + realNumber;
                    lastNumber = realNumber;
                    realNumber = fibonacci;
                }
        }


        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {
            long n = 0;
            long i = 1;
            long acc = 1;

            Console.WriteLine("Insira um número");
            n = long.Parse(Console.ReadLine());

            for (i = n; i != 0; i--)
            {
                acc *= i;
            }

            Console.WriteLine(acc);

        }

        #endregion

    }
}
