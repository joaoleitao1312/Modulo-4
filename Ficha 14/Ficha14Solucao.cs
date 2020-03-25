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

    }
}
