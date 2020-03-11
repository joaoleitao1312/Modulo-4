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
                Console.ForegroundColor
            = ConsoleColor.Green;
                Console.WriteLine("Passou");
                Console.ForegroundColor
            = ConsoleColor.White;
            }

            else
            {
                Console.ForegroundColor
            = ConsoleColor.Red;
                Console.WriteLine("Chumbou");
                Console.ForegroundColor
            = ConsoleColor.White;
            }
        }
        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            double peso = 0;
            double altura = 0;
            double imc = 0;
            Console.WriteLine("Introduza o seu peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a sua altura em metros");
            altura = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);

            if(imc < 18.5)
            {
                Console.WriteLine("O seu IMC é " + imc + " e está abaixo do peso");
            }

            if(imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("O seu IMC é " + imc + " e está normal");
            }

            if(imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("O seu IMC é " + imc + " e está acima do peso");
            }

            if(imc >= 30)
            {
                Console.WriteLine("O seu IMC é " + imc + " e está obeso");
            }

        }


        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            int numero = 0;
            Console.WriteLine("Introduza um número inteiro");
            numero = int.Parse(Console.ReadLine());

            if(numero % 3 == 0)
            {
                if (numero % 7 == 0)
                {
                    Console.WriteLine("O número " + numero + " é divisivel por 3 e 7");
                }

                else
                {
                    Console.WriteLine("Não divisivel por 3 e 7");
                }
            }

            else
            {
                Console.WriteLine("Não divisivel por 3 e 7");
            }
        }



        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            int numero = 0;
            Console.WriteLine("Introduza um número inteiro");
            numero = int.Parse(Console.ReadLine());

            if(numero >= 30 && numero <= 50)
            {
                Console.WriteLine("Número válido");
            }

            else
            {
                Console.WriteLine("Número não válido");
            }

        }



        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            int numero = 0;
            Console.WriteLine("Introduza um número inteiro");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10 && numero < 20)
            {
                Console.WriteLine("Número válido");
            }

            else
            {
                Console.WriteLine("Número não válido");
            }
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {
            int andar = 0;
            Console.WriteLine("Introduza o andar");
            andar = int.Parse(Console.ReadLine());

            if(andar == 3 || andar == 5 || andar < -2 || andar > 6)
            {
                Console.WriteLine("Andar não disponivel");
            }      

            else
            {
                Console.WriteLine("Andar disponivel");
            }
        }


        #endregion

        #region Exercicio7

        public static void Exercicio7DoWhile()
        {
            int i = 0;
            int acc = 0;

            do
            {

                Console.WriteLine("Introduza um número");
                int numero = int.Parse(Console.ReadLine());
                acc = numero + acc;
                i++;

            }
            while (i < 10);

            Console.WriteLine(acc);

        }

        public static void Exercicio7While()
        {
            int i = 0;
            int acc = 0;

            while (i < 10)
            {
                Console.WriteLine("Introduza um número");
                int numero = int.Parse(Console.ReadLine());
                acc = numero + acc;
                i++;
            }

            Console.WriteLine(acc);
        }

        public static void Exercicio7For()
        {
            int i = 0;
            int acc = 0;

            for (i=0; i<10; i++)
            {
                Console.WriteLine("Introduza um número");
                int numero = int.Parse(Console.ReadLine());
                acc = numero + acc;
            }

            Console.WriteLine(acc);
        }

        #endregion

        #region Exercicio8

        public static void Exercicio8()
        {
            int countNome = 0;
            var nome1 = "";
            var nome2 = "";
            var nome3 = "";
            var nome4 = "";
            var nome5 = "";
            decimal preco1 = 0;
            decimal preco2 = 0;
            decimal preco3 = 0;
            decimal preco4 = 0;
            decimal preco5 = 0;
            decimal quant1 = 0;
            decimal quant2 = 0;
            decimal quant3 = 0;
            decimal quant4 = 0;
            decimal quant5 = 0;
            decimal total1 = 0;
            decimal total2 = 0;
            decimal total3 = 0;
            decimal total4 = 0;
            decimal total5 = 0;


            do
            {
                Console.WriteLine("Introduza um nome");
                nome1 = Console.ReadLine();
                Console.WriteLine("Introduza um preço");
                preco1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a quantidade");
                quant1 = decimal.Parse(Console.ReadLine());
                total1 = preco1 * quant1;
                countNome++;
                Console.WriteLine("Introduza um nome");
                nome2 = Console.ReadLine();
                Console.WriteLine("Introduza um preço");
                preco2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a quantidade");
                quant2 = decimal.Parse(Console.ReadLine());
                total2 = preco2 * quant2;
                countNome++;
                Console.WriteLine("Introduza um nome");
                nome3 = Console.ReadLine();
                Console.WriteLine("Introduza um preço");
                preco3 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a quantidade");
                quant3 = decimal.Parse(Console.ReadLine());
                total3 = preco3 * quant3;
                countNome++;
                Console.WriteLine("Introduza um nome");
                nome4 = Console.ReadLine();
                Console.WriteLine("Introduza um preço");
                preco4 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a quantidade");
                quant4 = decimal.Parse(Console.ReadLine());
                total4 = preco4 * quant4;
                countNome++;
                Console.WriteLine("Introduza um nome");
                nome5 = Console.ReadLine();
                Console.WriteLine("Introduza um preço");
                preco5 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a quantidade");
                quant5 = decimal.Parse(Console.ReadLine());
                total5 = preco5 * quant5;
                countNome++;
            }
            while (countNome < 5);

            Console.WriteLine("Produto 1 = " + nome1 + " = " + total1 + "$");
            Console.WriteLine("Produto 2 = " + nome2 + " = " + total2 + "$");
            Console.WriteLine("Produto 3 = " + nome3 + " = " + total3 + "$");
            Console.WriteLine("Produto 4 = " + nome4 + " = " + total4 + "$");
            Console.WriteLine("Produto 5 = " + nome5 + " = " + total5 + "$");
            Console.WriteLine("Total da compra = " + (total1 + total2 + total3 + total4 + total5) + "$");

        }



        #endregion

        #region Exercicio9

        public static void Exercicio9()
        {
            int numeros = 0;
            int acc = 0;
            int count = -1;
            int media = 0;
            do
            {
                Console.WriteLine("Insira um número");
                numeros = int.Parse(Console.ReadLine());
                acc = numeros + acc;
                count++;
            }
            while (numeros != 0);

            media = acc / count;

            Console.WriteLine("Média igual a " + media);

        }


        #endregion

        #region Exercicio10

        public static void Exercicio10()
        {

            int num1 = 0;
            int num2 = 0;
            var operacao = "";
            Console.WriteLine("insere um numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insere um numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("insere uma operação");
            operacao = Console.ReadLine();

            switch (operacao)

            {

                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;

                case "%":
                    Console.WriteLine(num1 % num2);
                    break;

                default:
                    Console.WriteLine("Isso não é uma operação");
                    break;

            }
    
        }

        #endregion

        #region Exercicio11

        public static void Exercicio11()
        {
            Console.WriteLine("Escreve uma letra: ");
            var letra = char.Parse(Console.ReadLine());
            Tabela(letra, letra, 3, 3);
            
        }
        #endregion

        #region Tabela
        private static void Tabela(char letra1, char letra2, int n, int m)
        {
            var k = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if(k % 2 == 0) 
                    { 
                        Console.Write(letra1 + " ");
                    }
                    else
                    {
                        Console.Write(letra2 + " ");
                    }

                    k++;

                }

                Console.WriteLine("\n");
            }
        }

        #endregion

        #region Exercicio12
        public static void Exercicio12()
        {
            Console.WriteLine("Escreve uma letra: ");
            var letra = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número");
            int n = int.Parse(Console.ReadLine());
            Tabela(letra, letra, n, n);

        }

        #endregion

        #region Exercicio13
        public static void Exercicio13()
        {
            Console.WriteLine("Escreve uma letra: ");
            var letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreve uma letra: ");
            var letra2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número");
            int m = int.Parse(Console.ReadLine());
            Tabela(letra1, letra2, n, m);

        }

        #endregion

        #region Exercicio2.1

        public static void Exercicio14()
        {
            double temp = 0;
            char escala = ' ';
            Console.WriteLine("Introduz a temperatura");
            temp = double.Parse(Console.ReadLine());
            
            while (escala != 'C' && escala != 'K' && escala != 'F')
            {
                Console.WriteLine("Em que escala? (C,K OU F)");
                escala = char.Parse(Console.ReadLine());
            }

            switch (escala)
            {
                case 'C':
                    Console.WriteLine(temp + "ºC é equivalente a " + Math.Round((temp + 273.15), 2) + "K e " + (Math.Round((temp * 9 / 5 + 32), 2) + "ºF"));
                    break;

                case 'K':
                    Console.WriteLine(temp + "K é equivalente a " + Math.Round((temp - 273.15), 2) + "ºC e " + Math.Round((temp * 9 / 5 - 459.67), 2) + "ºF");
                    break;

                case 'F':
                    Console.WriteLine(temp + "ºF é equivalente a " + Math.Round(((temp - 32) * 5 / 9), 2) + "ºC e " + Math.Round(((temp + 459.67) * 5 / 9), 2) + "K");
                    break;

            }
            
        }

        #endregion

        #region Exercicio2.2

        public static void Exercicio15()
        {
            int num = 0;
            int cont = 0;
            Console.WriteLine("Qual o número limite?");
            num = int.Parse(Console.ReadLine());
            for(cont = 0; cont != num; cont++)
            {
                if(cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                }
            }
        }

        #endregion

        #region Exercicio2.3

        public static void Exercicio16()
        {
            var caracteres = "";
            var caracter = "";
            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                caracter = Console.ReadLine();
                caracteres = caracter + caracteres;
            }
            while(caracter != "");

            Console.WriteLine(caracteres);
        }

        #endregion

        #region Exercicio3.1

        public static void Exercicio17()
        {
            int n = 0;
            Console.WriteLine("Introduz um número");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n * 3);
            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }

        #endregion

        #region Exercicio3.2

        public static void Exercicio18()
        {
            int n = 0;
            int i = 1;
            Console.WriteLine("Qual a dimensão do triangulo?");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                n--;
                int a = 0;
                int b = 0;
                while (a != n)
                {

                    Console.Write(" ");                    
                    a++;

                }
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }

                i += 2;
                Console.Write("\n");
            }
        }

        #endregion


    }
}
