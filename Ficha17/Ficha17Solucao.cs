using System;

namespace Ficha17
{
    public class Ficha17Solucao
    {

        #region Exercicio1

        public static void Exercicio1()
        {
            Console.WriteLine("Insira uma frase");
            string frase = Console.ReadLine();

            Console.WriteLine("Introduza um índice");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O caracter na posição {i} é {frase[i]}");        
        }

        #endregion

        #region Solicitar String

        public static void SolicitarString(ref string frase)
        {
            Console.WriteLine("Insira uma frase");
            frase = Console.ReadLine();
        }

        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            Console.WriteLine("Insira uma frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Insira uma frase");
            string frase2 = Console.ReadLine();

            if (frase.Length != frase2.Length)
            {
                Console.WriteLine("As frases não tem o mesmo tamanho");
            }

            bool continuar = true;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < frase.Length; j++)
                {
                    if (frase[j] != frase2[j])
                    {
                        Console.WriteLine("As frases não são iguais");
                        continuar = false;
                        break;
                    }
                }

                if (!continuar)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("As frases são iguais");
                }
                
            }

        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            string frase = " ";

            SolicitarString(ref frase);

            int tam = frase.Length;
            int acc = 1;

            for (int i = 0; i < tam; i++)
            {
                if(frase[i] == ' ')
                {
                    acc++;
                }
            }

            Console.WriteLine(acc);
        }

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            string frase = " ";

            SolicitarString(ref frase);

            int tam = frase.Length;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(frase[i]);
            }
           
        }

        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            string frase = " ";

            SolicitarString(ref frase);

            int tam = frase.Length;

            int ultDez = tam - 10;

            for (int i = ultDez; i < tam; i++)
            {
                Console.Write(frase[i]);
            }
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {
            string frase = " ";

            SolicitarString(ref frase);

            int tam = frase.Length;

            string alfabeto = "abcdefghijklmnopqrstuvwxyz";

            int tam2 = alfabeto.Length;
            int j = 0;

            for (int i = 0; i < tam; i++)
            {
                for (j = 0; j < tam2; j++)
                {
                    if (frase[i] == alfabeto[j])
                    {
                        Console.WriteLine($"O caracter {frase[i]} está na posição {j + 1} do alfabeto");
                    }

                }
            }
        }

        #endregion

        #region Exercicio7

        public static void Exercicio7()
        {
            string frase = " ";

            SolicitarString(ref frase);

            int tam = frase.Length;
            

            for (int i = tam - 1; i >= 0; i--)
            {
                Console.Write($"{frase[i]}");
            }
        }

        #endregion

        #region Exercicio8

        public static void Exercicio8()
        {
            string frase = " ";

            SolicitarString(ref frase);

            int tam = frase.Length;
        }

        #endregion


    }
}
