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

        }

        #endregion
    }
}
