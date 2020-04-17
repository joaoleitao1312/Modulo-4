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
            int temp = 0;

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            int tam = valores.Length;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (valores[j] < valores[i])
                    {
                        temp = valores[i];
                        valores[i] = valores[j];
                        valores[j] = temp;
                    }
                }
            }

            int repetido = 0;
            var counter = 0;
            for (int j = 0; j < valores.Length; j++)
            {
                if (valores[j] != repetido)
                {
                    if (counter > 1)
                    {
                        Console.WriteLine(repetido + " = " + counter);
                    }
                    repetido = valores[j];
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

        #region Exercicio6

        public static void Exercicio6()
        {
            int[] valores = new int[10];
            

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            int tam = valores.Length;
            int temp = 0;

            for (int i = 0; i < tam; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (valores[j] < valores[i])
                    {
                        temp = valores[i];
                        valores[i] = valores[j];
                        valores[j] = temp;
                    }
                }
            }


            int counter = 0;

            for (int i = 0; i < tam; i++)
            {
                counter = 0;                
                for (int j = 0; j < i - 1; j++)
                {
                    
                    if (valores[i] == valores[j])
                    {
                        counter++;
                    }
                }

                for (int k = i + 1; k < tam; k++)
                {

                    if (valores[i] == valores[k])
                    {
                        counter++;
                    }

                    if (valores[i] == valores[i + 1])
                    {
                        i++;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine($"{valores[i]}");
                }
            }

        }

        #endregion

        #region Exercicio7

        public static void Exercicio7()
        {
            int[] valores = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            int menor = valores[0];
            for (int i = 0; i < 10; i++)

            {
                if (valores[i] < menor)
                {
                    menor = valores[i];

                }
            }
            int maior = valores[9];
            for (int i = 0; i < 10; i++)
            {

                if (valores[i] > maior)
                {
                    maior = valores[i];

                }
            }
            Console.WriteLine($"O maior número é {maior}");
            Console.WriteLine($"O menor número é {menor}");
        }

        #endregion

        #region Exercicio8

        public static void Exercicio8()
        {
            int[] valores = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];
            int tam = 0;
            int j = 0;
            int k = 0;

            Console.WriteLine("Insira um tamanho para o array");
            tam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tam; i++)
            {               
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());         
            }

            for (int i = 0; i < tam; i++)
            {
                if (valores[i] % 2 == 0)
                {
                    pares[j] = valores[i];
                    j++;
                }
                else
                {
                    impares[k] = valores[i];
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

        #region Exercicio9

        public static void Exercicio9()
        {
            int[] valores = new int[10];
            int tam = valores.Length;

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Insira um valor");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Insira um valor a ser encontrado");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tam; i++)
            {
                if (valores[i] == num)
                {
                    Console.WriteLine($"{num} encontra-se no array na posição {i}");
                    break;
                }
            }



        }

        #endregion
    }
}
