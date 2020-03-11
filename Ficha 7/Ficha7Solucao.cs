using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        #region Exercicio1
        public static void Exercicio71()
        {
            double nota = 0;
            Console.WriteLine("Introduza uma nota");
            nota = double.Parse(Console.ReadLine());
            if (nota > 9.44)
            {
                Console.WriteLine("Passou");
            }

            else
            {
                Console.WriteLine("Chumbou");
            }
        }
        #endregion
    }
}
