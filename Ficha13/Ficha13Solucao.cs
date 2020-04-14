using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {

        #region Soma

        private static void Sum(int num2, double resultado)
        {
            Console.Write(" ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado += num2;
            Console.WriteLine(" " + resultado);
        }

        #endregion

        #region Sub

        private static void Sub(int num2, double resultado)
        {
            Console.Write(" ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado -= num2;
            Console.WriteLine(" " + resultado);
        }

        #endregion

        #region Calculadora

        public static void Calculadora ()
        {
            bool continuar1 = true;
            bool continuar2 = true;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("    Calculadora   " + "\n" +
                " Num Lock  / * -  " + "\n" +
                "   7   8   9      " + "\n" +
                "   4   5   6   +  " + "\n" +
                "   1   2   3      " + "\n" +
                "   0   .  esc     " + "\n" +
                "                  ");
            Console.ResetColor();
            Console.Write(" ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");
            string op = Convert.ToString(Console.ReadLine());
            do
            {
                
                if (op == "+")
                {
                    Console.Write(" ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    double resultado;
                    resultado = num1 + num2;
                    Console.WriteLine(" " + resultado);

                    do
                    {

                        Console.Write(" ");
                        op = Convert.ToString(Console.ReadLine());

                        if (op == "+")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado += num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "-")
                        {
                            Sub(num2, resultado);
                        }

                        if (op == "*")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado *= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "/")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado /= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "esc")
                        {
                            continuar2 = false;
                            continuar1 = false;
                        }


                    }
                    while (continuar2 != false);
    
                }

                if (op == "-")
                {
                    Console.Write(" ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    double resultado = 0;
                    resultado = num1 - num2;
                    Console.WriteLine(" " + resultado);

                    do
                    {

                        Console.Write(" ");
                        op = Convert.ToString(Console.ReadLine());

                        if (op == "+")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado += num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "-")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado -= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "*")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado *= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "/")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado /= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "esc")
                        {
                            continuar2 = false;
                            continuar1 = false;
                        }


                    }
                    while (continuar2 != false);

                }

                if (op == "*")
                {
                    Console.Write(" ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    double resultado = 0;
                    resultado = num1 * num2;
                    Console.WriteLine(" " + resultado);

                    do
                    {

                        Console.Write(" ");
                        op = Convert.ToString(Console.ReadLine());

                        if (op == "+")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado += num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "-")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado -= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "*")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado *= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "/")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado /= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "esc")
                        {
                            continuar2 = false;
                            continuar1 = false;
                        }


                    }
                    while (continuar2 != false);

                }

                if (op == "/")
                {
                    Console.Write(" ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    double resultado = 0;
                    resultado = num1 / num2;
                    Console.WriteLine(" " + resultado);

                    do
                    {

                        Console.Write(" ");
                        op = Convert.ToString(Console.ReadLine());

                        if (op == "+")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado += num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "-")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado -= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "*")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado *= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "/")
                        {
                            Console.Write(" ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            resultado /= num2;
                            Console.WriteLine(" " + resultado);
                        }

                        if (op == "esc")
                        {
                            continuar2 = false;
                            continuar1 = false;
                        }


                    }
                    while (continuar2 != false);

                }

            }
            while (continuar1 && continuar2 != false);

        }                      

        #endregion

        #region Galo



        #endregion    

        #region Forca

        public static void Forca() 
        {

            #region PalavraRandom

            Random number = new Random();
            int wordNumber = number.Next(1, 11);

            string p1 = "BANANA";
            string p2 = "ARROZ";
            string p3 = "CORONA";
            string p4 = "CARRO";
            string p5 = "TAPETE";
            string p6 = "FACIL";
            string p7 = "ESQUEMA";
            string p8 = "DIFICIL";
            string p9 = "MITIGAR";
            string p10 = "QUARENTENA";
            string palQuest = " ";

            if (wordNumber == 1)
            {
                palQuest = p1;
            }

            else if (wordNumber == 2)
            {
                palQuest = p2;
            }

            else if (wordNumber == 3)
            {
                palQuest = p3;
            }

            else if (wordNumber == 4)
            {
                palQuest = p4;
            }

            else if (wordNumber == 5)
            {
                palQuest = p5;
            }

            else if (wordNumber == 6)
            {
                palQuest = p6;
            }

            else if (wordNumber == 7)
            {
                palQuest = p7;
            }

            else if (wordNumber == 8)
            {
                palQuest = p8;
            }

            else if (wordNumber == 9)
            {
                palQuest = p9;
            }

            else if (wordNumber == 10)
            {
                palQuest = p10;
            }

            #endregion

            string letraResposta = " ";
            bool jogar = false;
            var letra = " ";            
            string palResposta = " ";
            int erros = 0, fim = 0;
            int letterCounter = palQuest.Length;
            var _ = "_";
            var espaco = " ";
            var guess = " ";
            var wrong = " ";

            for (var i = 0; i < palQuest.Length; i++)
            {
                guess += "_ ";                
            }

            while (!jogar)
            {
                Console.Clear();
                Console.WriteLine("Jogo da forca \n" +
                  "  _____, \n" +
                  " /     | \n" +
                  " |       \n" +
                  " |       \n" +
                  " |       \n" +
                  " |       \n" +
                  " |       \n" +
                  "=========     " + guess + '\n' +
                  "              " + wrong);
                Console.WriteLine("Introduz uma letra");
                char letter = Console.ReadKey().KeyChar;
                if (palQuest.Contains(letter))
                {

                    for (int i = 0; i < palQuest.Length; i++)
                    {

                        //if (ExtensionMethods.CharAt(palQuest, i) == letter)
                        {
                            guess = guess.Remove(i * 2, 1).Insert(i * 2, letter.ToString());
                        }

                    }

                }

                else
                {
                    wrong += letter;
                }

                if (palQuest.Equals(guess.Replace(" ", "")))
                {
                    Console.Clear();
                    Console.WriteLine("\nGanhaste.");
                    jogar = true;
                }


                //var headHangman = " ";
                //var bodyHangman = " ";
                //var leftArmHangman = " ";
                //var rightArmHangman = " ";
                //var leftLegHangman = " ";
                //var rightLegHangman = " ";
                //int wrongLetterCount = 0;

                //if (wrongLetterCount >= 1)
                //    headHangman = "O";
                //if (wrongLetterCount >= 2)
                //    bodyHangman = "|";
                //if (wrongLetterCount >= 3)
                //    leftArmHangman = "/";
                //if (wrongLetterCount >= 4)
                //    rightArmHangman = "\\";
                //if (wrongLetterCount >= 5)
                //    leftLegHangman = "/";
                //if (wrongLetterCount >= 6)
                //    rightLegHangman = "\\";

                //Console.WriteLine($"______" + '\n' +
                //                  $"|     |" + '\n' +
                //                  $"|     {headHangman}" + '\n' +
                //                  $"|   {leftArmHangman}{ bodyHangman}{ rightArmHangman}" + '\n' +
                //                  $"|    { bodyHangman}" + '\n' +
                //                  $"|   {leftLegHangman} { rightLegHangman}" + '\n' +
                //                  $"|" + '\n' +
                //                  $"|_");

                //Carlos: Francamente
                //Vasco: Ó Leitão, pá, não digas coisas dessas!
                //Leitão: Só digo coisas ofensivas

            }
        }

        #endregion



    }
}
