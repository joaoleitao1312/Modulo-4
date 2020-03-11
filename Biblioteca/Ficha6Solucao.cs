using System;

namespace Ficha6
{
    public class Ficha6Solucao
    {
        #region Exercicio1

        public static void Exercicio1()
        {
            Console.WriteLine("Qual o teu nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }

        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }

        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
        }

        public static int ConverterStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }


        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }


        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            Console.WriteLine("Num 3?");
            var num3 = Console.ReadLine();
            Console.WriteLine("Num 4?");
            var num4 = Console.ReadLine();
            Console.WriteLine("Num 5?");
            var num5 = Console.ReadLine();
            Console.WriteLine("Num 6?");
            var num6 = Console.ReadLine();
            Console.WriteLine("Num 7?");
            var num7 = Console.ReadLine();
            Console.WriteLine("Num 8?");
            var num8 = Console.ReadLine();
            Console.WriteLine("Num 9?");
            var num9 = Console.ReadLine();
            Console.WriteLine("Num 10?");
            var num10 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero3(num1);
            var num2Conv = ConverterStringParaNumero3(num2);
            var num3Conv = ConverterStringParaNumero3(num3);
            var num4Conv = ConverterStringParaNumero3(num4);
            var num5Conv = ConverterStringParaNumero3(num5);
            var num6Conv = ConverterStringParaNumero3(num6);
            var num7Conv = ConverterStringParaNumero3(num7);
            var num8Conv = ConverterStringParaNumero3(num8);
            var num9Conv = ConverterStringParaNumero3(num9);
            var num10Conv = ConverterStringParaNumero3(num10);
            ApresentarSoma3(num1Conv, num2Conv, num3Conv, num4Conv, num5Conv, num6Conv, num7Conv, num8Conv, num9Conv, num10Conv);
        }

        public static int ConverterStringParaNumero3(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }


        public static void ApresentarSoma3(int numA, int numB, int numC, int numD, int numE, int numF, int numG, int numH, int numI, int numJ)
        {
            Console.WriteLine(numA + " + " + numB + " + " + numC + " + " + numD + " + " + numE + " + " + numF + " + " + numG + " + " + numH + " + " + numI + " + " + numJ + " = " + (numA + numB + numC + numD + numE + numF + numG + numH + numI + numJ));
        }



        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            Console.WriteLine("Insira número para A");
            var a = Console.ReadLine();
            Console.WriteLine("Insira número B");
            var b = Console.ReadLine();
            var c = ConverterNumeros(a);
            var c2 = ConverterNumeros(b);
            ApresentarNumerosTrocados(c, c2);
        }

        public static int ConverterNumeros(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }

        public static void ApresentarNumerosTrocados(int c, int c2)
        {
            Console.WriteLine("A = " + c2 + " B = " + c);
        }



        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            var conta1 = "-1 + 4 * 6 = ";
            int a = -1;
            int b = 4;
            int c = 6;
            Console.WriteLine(conta1 + (a + b * c));
            var conta2 = "(35 + 5) % 7 = ";
            int d = 35;
            int e = 5;
            int f = 7;
            Console.WriteLine(conta2 + ((d + e) % f));
            var conta3 = "14 + -4 * 6 / 11 = ";
            int g = 14;
            int h = -4;
            int i = 11;
            Console.WriteLine(conta3 + (g + h * c / i));
            var conta4 = "2 + 15 / 6 * 1 – 7 % 2 = ";
            int j = 2;
            int k = 15;
            int l = 1;
            Console.WriteLine(conta4 + (j + k / c * l - f % j));
        }



        #endregion

        #region Exercicio6

        public static void Exercicios6()
        {
            Console.WriteLine("Insere um numero");
            var a = Console.ReadLine();
            var aConv = ConverterNumeroAgain(a);
            ApresentarTabuada(aConv);
        }

        public static int ConverterNumeroAgain(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }

        public static void ApresentarTabuada(int aConv)
        {
            Console.WriteLine("1 * " + aConv + " = ");
        }




        #endregion

        #region Exercicio7

        public static void Exercicio7()
        {
            Console.WriteLine("Escreva o 1º número: ");
            var a = Console.ReadLine();
            Console.WriteLine("Escreva o 2º número: ");
            var b = Console.ReadLine();
            var a2 = ConverterNumero(a);
            var b2 = ConverterNumero(b);
            ApresentarMedia(a2, b2);
        }

        public static int ConverterNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }

        public static void ApresentarMedia(int a2, int b2)
        {
            Console.WriteLine("A media de " + a2 + " e " + b2 + " é igual a " + ((a2 + b2) / 2));
        }

        #endregion

        #region Exercicio8

        public static void Exercicio8()
        {
            Console.WriteLine("Escreve o 1º número: ");
            var a = Console.ReadLine();
            Console.WriteLine("Escrever o 2º número: ");
            var b = Console.ReadLine();
            Console.WriteLine("Escrever o 3º número: ");
            var c = Console.ReadLine();
            Console.WriteLine("Escrever o 4º número: ");
            var d = Console.ReadLine();
            Console.WriteLine("Escrever o 5º número: ");
            var e = Console.ReadLine();
            var a2 = ConverterNumeroParaMedia(a);
            var b2 = ConverterNumeroParaMedia(b);
            var c2 = ConverterNumeroParaMedia(c);
            var d2 = ConverterNumeroParaMedia(d);
            var e2 = ConverterNumeroParaMedia(e);
            ApresentarMedia2(a2, b2, c2, d2, e2);
        }

        public static int ConverterNumeroParaMedia(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }

        public static void ApresentarMedia2(int a2, int b2, int c2, int d2, int e2)
        {
            Console.WriteLine("A média de " + a2 + ", " + b2 + ", " + c2 + ", " + d2 + " e " + e2 + " é igual a " + ((a2 + b2 + c2 + d2 + e2) / 5));
        }


        #endregion

        #region Exercicio10

        public static void Exercicio10()
        {
            Console.WriteLine("Escreve uma letra: ");
            var letra = Console.ReadLine();
            Console.WriteLine(letra + " " + letra + " " + letra + "\n" + letra + " " + letra + " " + letra + "\n" + letra + " " + letra + " " + letra);
        }


        #endregion

        #region Exercicio11

        public static void Exercicio11()
        {
            string nomeProd1, nomeProd2, nomeProd3, preçoProd1, preçoProd2, preçoProd3, quantProd1, quantProd2, quantProd3;


            Console.WriteLine("Escrever o nome do produto: ");
            nomeProd1 = Console.ReadLine();
            Console.WriteLine("Escrever o preço do produto: ");
            preçoProd1 = Console.ReadLine();
            Console.WriteLine("Escrever a quantidade do produto");
            quantProd1 = Console.ReadLine();
            Console.WriteLine("Escrever o nome do produto: ");
            nomeProd2 = Console.ReadLine();
            Console.WriteLine("Escrever o preço do produto: ");
            preçoProd2 = Console.ReadLine();
            Console.WriteLine("Escrever a quantidade do produto");
            quantProd2 = Console.ReadLine();
            Console.WriteLine("Escrever o nome do produto: ");
            nomeProd3 = Console.ReadLine();
            Console.WriteLine("Escrever o preço do produto: ");
            preçoProd3 = Console.ReadLine();
            Console.WriteLine("Escrever a quantidade do produto");
            quantProd3 = Console.ReadLine();
            var precoProd1Conv = ConverterNumeros2(preçoProd1);
            var precoProd2Conv = ConverterNumeros2(preçoProd2);
            var precoProd3Conv = ConverterNumeros2(preçoProd3);
            var quantProd1Conv = ConverterNumeros2(quantProd1);
            var quantProd2Conv = ConverterNumeros2(quantProd2);
            var quantProd3Conv = ConverterNumeros2(quantProd3);
            ApresentarTotais(nomeProd1, nomeProd2, nomeProd3, precoProd1Conv, precoProd2Conv, precoProd3Conv, quantProd1Conv, quantProd2Conv, quantProd3Conv); 
        }

        public static decimal ConverterNumeros2(string num)
        {
            var parseOk = decimal.TryParse(num, out decimal parsedNum);
            return parsedNum;
        }

        public static void ApresentarTotais(string nomeProd1, string nomeProd2, string nomeProd3, decimal precoProd1Conv, decimal precoProd2Conv, decimal precoProd3Conv, decimal quantProd1Conv, decimal quantProd2Conv, decimal quantProd3Conv)
        {
            Console.WriteLine("Total de " + nomeProd1 + " = " + precoProd1Conv * quantProd1Conv);
            Console.WriteLine("Total de " + nomeProd2 + " = " + precoProd2Conv * quantProd2Conv);
            Console.WriteLine("Total de " + nomeProd3 + " = " + precoProd3Conv * quantProd3Conv);
            Console.WriteLine("Total da Compra = " + ((precoProd1Conv * quantProd1Conv) + (precoProd2Conv * quantProd2Conv) + (precoProd3Conv * quantProd3Conv)));
        }



        #endregion

        #region Exercicio2.1

        public static void Exercicio21()
        {
            var x = " ";
            Console.WriteLine("Diz-me algo que eu não saiba");
            x = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + x);
        }
        #endregion

        #region Exercicio2.2

        public static void Exercicio22()
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Introduz um número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz outro número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("O primeiro número é " + a + " e o segundo é " + b);
        }

        #endregion

        #region Exercicio2.3

        public static void Exercicio23()
        {
            double a = 0;
            double tempF = 0;
            double tempK = 0;
            Console.WriteLine("Introduz a temperatura");
            a = double.Parse(Console.ReadLine());
            tempF = a * 9 / 5 + 32;
            tempK = a + 273.15;
            Console.WriteLine("A temperatura " + a + "ºC é " + tempF + "ºF e " + tempK + "ºK");

        }

        #endregion

        #region Exercicio 3.1

        public static void Exercicio31()
        {
            int horas = 0;
            int minutos = 0;
            int segundos = 0;
            int total = 0;
            Console.WriteLine("Introduz as horas");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz os minutos");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz os segundo");
            segundos = int.Parse(Console.ReadLine());
            total = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos + " é equivalente a " + total + " segundos");
        }


        #endregion

        #region Exercicio 3.2
        
        public static void Exercicio32()
        {

            double raio = 0;
            double area = 0;
            double perimetro = 0;
            Console.WriteLine("Qual é o raio?");
            raio = double.Parse(Console.ReadLine());
            perimetro = 2 * 3.14 * raio;
            area = 3.14 * raio * raio;
            Console.WriteLine("A area do circulo é " + area + " e o perimetro é " + perimetro);

        }

        #endregion



    }
}
