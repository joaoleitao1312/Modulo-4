using System;
using System.IO;
using System.Collections.Generic;


namespace Testes
{
    public class Testes
    {

        public static void Summarize()
        {
            string exemplo = "Bom Noite";



            Console.WriteLine(exemplo[2]); //output = m
            //Imprime o caracter no indice 2 da string

            string exemplo2 = exemplo.Substring(4, 5); //output  = Noite
            //Cria um outra string que começa no indice 4 e tem 5 caracteres de tamanho

            exemplo.Replace('m', 'a'); //output = Boa Noite
            //Troca todos os m's por a's

            exemplo.ToUpper(); //output = BOA NOITE
            //Faz com que todas as letras fiquem em Maiusculas

            Console.WriteLine(exemplo.Contains('F')); //output = False
            //Verifica se a string tem determinado caracter


            var data = new DateTime(2000, 12, 13, 11, 55, 57); //output = 13/12/2000  11:55:57

            var data2 = DateTime.Now; //output = data do computador

            var data3 = DateTime.UtcNow; //output = data utc

            var potencia = Math.Pow(8, 3); //output = 512
            //Imprime o resultado de 8 elevado a 3

            var ip = Math.PI; //output = 3.141592653589793
            //Imprime o valor de pi

            var oMaior = Math.Max(1, 10); //output = 10
            //Imprime o maior valor entre os dois inseridos

            var chao = Math.Floor(2.4); //output = 2
            //Imprime o valor arredondado mais proximo de - infinito

            var teto = Math.Ceiling(2.4); //output = 3
            //Imprime o valor arrednodado mais proximo de + infinito

            var redondo = Math.Round(2.4); //output = 3
            //Imprime o valor arredondado mais afastado de zero

            var truncar = Math.Truncate(2.4); //output = 2
            //Imprime o valor arredondado menos afastado de zero

            string caminho = @"D:\Tudo\teste.txt";

            if (!File.Exists(caminho)) //output = false
            {
                //Cria um ficheiro teste no caminho indicado acima
                using (StreamWriter sw = File.CreateText(caminho))
                {
                    sw.WriteLine("No inicio da solução é necessário inserir");
                    sw.WriteLine("using System.IO; para poder usar a classe File");
                }
            }

            //Abre o ficheiro para ser lido
            using (StreamReader sr = File.OpenText(caminho))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s); //output = No inicio da solução é necessário inserir \n using System.IO; para poder usar a classe File
                }
            }

            int[] numeros = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Cria o vetor

            Console.WriteLine(numeros[5]); //output = 6
            //Imprime o valor indicado pelo indice

            numeros[0] = 0;
            //Troca o valor do indice indicado pelo valor dado

            List<int> numerus = new List<int>();
            //Cria a Lista e para isso é necessário inserir using System.Collections.Generic;

            numerus.Add(1);
            numerus.Add(2);
            numerus.Add(3);
            //Adiciona valores a lista

            Console.WriteLine(numerus[2]); //output = 3
            //Imprime o valor indicado pelo indice


        }
    }

    public class TesteExtensao
    {
        public static void ExtensaoTeste()
        {
            int numero = 10;

            bool result = numero.EMaiorQue(100); //Chamamento do Metodo de Extensao

            Console.WriteLine(result);
        }
    }


    public static class ExtensionMethods //Criação do Metodo de Extensão
    {
        public static bool EMaiorQue(this int i, int value)
        {
            return i > value;
        }
    }

    public enum Carros
    {
        Opel,
        Volvo,
        Fiat,
        Seat
    }

    public class Juanita
    {
        public static void Alejandra()
        {
            Console.WriteLine(Carros.Fiat);
        }
    }


}
