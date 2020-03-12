using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {
        #region Exercicio 2
        #endregion
        #region Exercicio1

        public static void Exercicio1()
        {

            char operacao = ' ';
            double number1 = 0;
            double number2 = 0;
            double resultado = 0;
            bool continuar = true;
            bool continuar2 = true;
            var continuar3 = " ";
            bool continuar4 = true;

            Console.WriteLine("----------Calculadora----------");
            Console.WriteLine(" ");
            Console.Write("Insira um número: ");
            double.TryParse(Console.ReadLine(), out number1);

            do
            {
                Console.Write("Insira uma operação (+ , -, *, /): ");
                char.TryParse(Console.ReadLine(), out operacao);
                if (operacao != '+' && operacao != '-' && operacao != '*' && operacao != '/')
                {
                    Console.ForegroundColor
                        = ConsoleColor.DarkRed;
                    Console.WriteLine("Insere uma operação igual as apresentadas!!!");
                    Console.ForegroundColor
                        = ConsoleColor.White;
                }
                else
                {
                    Console.Write("Insira um número: ");
                    double.TryParse(Console.ReadLine(), out number2);
                    
                    do
                    {
                        switch (operacao)
                        {
                            case '+':
                                resultado = number1 + number2;
                                Console.WriteLine(number1 + " + " + number2 + " = " + resultado);
                                Console.Write("Queres cancelar a conta (s/n): ");
                                continuar3 = Console.ReadLine();
                                if (continuar3 == "s")
                                {
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Write("Insira uma operação (+ , -, *, /): ");
                                    char.TryParse(Console.ReadLine(), out operacao);
                                    if (operacao != '+' && operacao != '-' && operacao != '*' && operacao != '/')
                                    {
                                        Console.ForegroundColor
                                            = ConsoleColor.DarkRed;
                                        Console.WriteLine("Insere uma operação igual as apresentadas!!!");
                                        Console.ForegroundColor
                                            = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        do
                                        {
                                            Console.Write("Insira um número: ");
                                            double.TryParse(Console.ReadLine(), out number2);
                                            resultado += resultado;
                                            Console.WriteLine(resultado);
                                            continuar4 = false;
                                        }
                                        while (continuar4);

                                }
                                    continuar2 = false;
                                    break;
                                }
                                
                                continuar2 = false;
                                break;
                            case '-':
                                resultado = number1 - number2;
                                Console.WriteLine(number1 + " - " + number2 + " = " + resultado);
                                Console.Write("Queres cancelar a conta (s/n): ");
                                continuar3 = Console.ReadLine();
                                if (continuar3 == "s")
                                {
                                    Console.Clear();
                                }
                                continuar2 = false;
                                break;
                            case '*':
                                resultado = number1 * number2;
                                Console.WriteLine(number1 + " * " + number2 + " = " + resultado);
                                Console.Write("Queres cancelar a conta (s/n): ");
                                continuar3 = Console.ReadLine();
                                if (continuar3 == "s")
                                {
                                    Console.Clear();
                                }
                                else 
                                continuar2 = false;
                                break;
                            case '/':
                                resultado = number1 / number2;
                                if (number2 == 0)
                                {
                                    Console.ForegroundColor
                                        = ConsoleColor.DarkRed;
                                    Console.WriteLine("Impossível dividir por 0. Tenta outra bez");
                                    Console.ForegroundColor
                                        = ConsoleColor.White;                                    
                                    break;
                                }
                                else 
                                { 
                                    Console.WriteLine(number1 + " / " + number2 + " = " + resultado);
                                    continuar2 = false;
                                    break;
                                }                                                               
                            default:
                                break;
                        }
                    }
                    while (continuar2);

                    
                }

            }
            while (continuar);

        }

        #endregion

    }
}
