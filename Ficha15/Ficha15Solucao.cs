using System;

namespace Ficha15
{
    public class Ficha15Solucao
    {

        #region Exercicio1

        public static void Exercicio1()
        {

            int[] valores = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine(valores[j]);
            }

        }

        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {

            int[] valores = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine(valores[j]);
            }

        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {

            int[] valores = new int[10];
            int acc = 0;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j <= 9; j++)
            {
                acc += valores[j];              
            }

        Console.WriteLine(acc);

        }

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            int[] valores = new int[10];           

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(valores.Length);

        }

        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            int[] valores = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine(valores[j]);
            }

        }

        #endregion


    }
}
