using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {


        #region Exercicio1

        public static void Exercicio1()
        {


            var operacao = "";
            double number1 = 0;
            double number2 = 0;
            double resultado = 0;
            bool continuar = true;
            bool continuar2 = true;
            char continuar3 = ' ';
            //bool continuar4 = true;
            bool continuar5 = true;
            //char enter = ' ';
            //char continuarConta = ' ';

            //Menu(number1);
            Console.WriteLine("----------Calculadora----------");
            Console.WriteLine(" ");
            Console.Write("Insira um número: ");
            double.TryParse(Console.ReadLine(), out number1);
            do
            {
                Console.Write("Insira uma operação(+ , -, *, /):");
                operacao = (Console.ReadLine());
                if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
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
                        continuar5 = true;
                        continuar2 = true;
                        switch (operacao)
                        {
                            case "+":
                                resultado = number1 + number2;
                                Console.WriteLine(number1 + " + " + number2 + " = " + resultado);
                                Console.Write("Queres continuar a conta (s/n): ");
                                continuar3 = char.Parse(Console.ReadLine());
                                if (continuar3 == 'n')
                                {
                                    continuar = false;
                                    continuar2 = false;
                                }
                                else
                                {
                                    Console.Write("Insira uma operação(+ , -, *, /):");
                                    if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
                                    {
                                        Console.ForegroundColor
                                            = ConsoleColor.DarkRed;
                                        Console.WriteLine("Insere uma operação igual as apresentadas!!!");
                                        Console.ForegroundColor
                                            = ConsoleColor.White;
                                    }
                                    else if (operacao == "+" && operacao == "-" && operacao == "*" && operacao == "/")
                                    {
                                        Console.Write("Insira um número: ");
                                        double.TryParse(Console.ReadLine(), out number2);
                                        continuar2 = false;
                                    }
                                }
                                break;
                            case "-":
                                resultado = number1 - number2;
                                Console.WriteLine(number1 + " - " + number2 + " = " + resultado);
                                Console.Write("Queres cancelar a conta (s/n): ");
                                continuar3 = char.Parse(Console.ReadLine());
                                if (continuar3 == 's')
                                {
                                    continuar = false;
                                    continuar2 = false;
                                }
                                else
                                {
                                    continuar2 = false;
                                }
                                break;
                            case "*":
                                resultado = number1 * number2;
                                Console.WriteLine(number1 + " * " + number2 + " = " + resultado);
                                Console.Write("Queres cancelar a conta (s/n): ");
                                continuar3 = char.Parse(Console.ReadLine());
                                if (continuar3 == 's')
                                {
                                    continuar = false;
                                    continuar2 = false;
                                }
                                else
                                {
                                    continuar2 = false;
                                }
                                break;
                            case "/":
                                resultado = number1 / number2;
                                if (number2 == 0)
                                {
                                    Console.ForegroundColor
                                        = ConsoleColor.DarkRed;
                                    Console.WriteLine("Impossível dibidir por 0. Tenta outra bez");
                                    Console.ForegroundColor
                                        = ConsoleColor.White;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(number1 + " / " + number2 + " = " + resultado);
                                    Console.Write("Queres cancelar a conta (s/n): ");
                                    continuar3 = char.Parse(Console.ReadLine());
                                    if (continuar3 == 's')
                                    {
                                        continuar = false;
                                        continuar2 = false;
                                    }
                                    else
                                    {
                                        continuar2 = false;
                                    }
                                    break;
                                }
                            case "C":
                                return;
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
