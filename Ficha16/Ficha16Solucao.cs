using System;
using System.Collections.Generic;

namespace Ficha16
{
    public class Ficha16Solucao
    {
        #region PedirNumeros

        public static void PedirNumeros(ref List<int> numeros)
        {
            numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }
        }

        #endregion

        #region Sort

        public static void Sort(ref List<int> numeros)
        {

            int tam = numeros.Count;
            int temp = 0;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (numeros[j] < numeros[i])
                    {
                        temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }
        }

        #endregion

        #region Exercicio1

        public static void Exercicio1()
        {

            List<int> numeros = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }

        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            List<int> numeros = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }

            numeros.Reverse();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{numeros[i]}");
            }

        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }

            int acc = 0;

            for (int i = 0; i < 10; i++)
            {
                acc += numeros[i];
            }

            Console.WriteLine($"{acc}");


        }

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }

            int tam = numeros.Count;
            int temp = 0;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (numeros[j] < numeros[i])
                    {
                        temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }

            int repetido = 0;
            var counter = 0;
            for (int j = 0; j < numeros.Count; j++)
            {
                if (numeros[j] != repetido)
                {
                    if (counter > 1)
                    {
                        Console.WriteLine(repetido + " = " + counter);
                    }
                    repetido = numeros[j];
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }
            if (counter > 1)
            {
                Console.WriteLine(repetido + " = " + counter);
            }
        }

        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }

            int tam = numeros.Count;
            int temp = 0;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (numeros[j] < numeros[i])
                    {
                        temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }

            int counter = 0;

            for (int i = 0; i < tam; i++)
            {
                counter = 0;
                for (int j = 0; j < i - 1; j++)
                {

                    if (numeros[i] == numeros[j])
                    {
                        counter++;
                    }
                }

                for (int k = i + 1; k < tam; k++)
                {

                    if (numeros[i] == numeros[k])
                    {
                        counter++;
                    }

                    if (numeros[i] == numeros[i + 1])
                    {
                        i++;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine($"{numeros[i]}");
                }
            }
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {

            List<int> numeros = new List<int>();

            //PedirNumeros(numeros);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor");
                int j = Convert.ToInt32(Console.ReadLine());
                numeros.Add(j);
            }            

            int tam = numeros.Count;
            int temp = 0;

            //Sort(numeros);

            int menor = numeros[0];
            for (int i = 0; i < 10; i++)

            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];

                }
            }
            int maior = numeros[9];
            for (int i = 0; i < 10; i++)
            {

                if (numeros[i] > maior)
                {
                    maior = numeros[i];

                }
            }

            Console.WriteLine($"O maior número é {maior}");
            Console.WriteLine($"O menor número é {menor}");

        }

        #endregion

        #region Exercicio7

        public static void Exercicio7()
        {

            List<int> numeros = new List<int>();

            PedirNumeros(ref numeros);

            int tam = numeros.Count;

            Sort(ref numeros);           

            int k = 0;
            int j = 0;

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < tam; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares.Add(numeros[i]);
                    j++;
                }
                else
                {
                    impares.Add(numeros[i]);
                    k++;
                }
            }

            Console.WriteLine("Pares");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{pares[i]}");
            }

            Console.WriteLine("Impares");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{impares[i]}");
            }

        }

        #endregion

        #region Exercicio8

        public static void Exercicio8()
        {

            List<int> numeros = new List<int>();

            PedirNumeros(ref numeros);

            int tam = numeros.Count;

            Sort(ref numeros);

            Console.WriteLine("Insira um valor a ser encontrado");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tam; i++)
            {
                if (numeros[i] == num)
                {
                    Console.WriteLine($"{num} encontra-se no Lista na posição {i}");
                    break;
                }
            }


        }

        #endregion

    }
}
