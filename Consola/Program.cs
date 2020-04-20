using Ficha10;
using Ficha11;
using Ficha12;
using Ficha13;
using Ficha14;
using Ficha15;
using Ficha16;
using Ficha17;
using System;
using Testes;
using Ficha24;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ficha10Solucao.Exercicio1();*/
            /*Ficha10Solucao.Exercicio2();*/
            /*Ficha10Solucao.Exercicio3();*/
            /*Ficha10Solucao.Exercicio4();*/
            /*Ficha10Solucao.Exercicio5();*/
            /*Ficha10Solucao.Exercicio7();*/
            /*Ficha10Solucao.Exercicio8();*/
            /*Ficha10Solucao.Exercicio10();*/
            //Ficha10Solucao.Exercicio11();
            //Ficha10Solucao.Exercicio12();
            //Ficha10Solucao.Exercicio13();
            //Ficha10Solucao.Exercicio14();
            //Ficha10Solucao.Exercicio15();
            //Ficha10Solucao.Exercicio16();

            //Ficha11Solucao.Exercicio71();
            //Ficha11Solucao.Exercicio2();
            //Ficha11Solucao.Exercicio3();
            //Ficha11Solucao.Exercicio4();
            //Ficha11Solucao.Exercicio5();
            //Ficha11Solucao.Exercicio6();
            //Ficha11Solucao.Exercicio7DoWhile();
            //Ficha11Solucao.Exercicio7While();
            //Ficha11Solucao.Exercicio7For();
            //Ficha11Solucao.Exercicio8();
            //Ficha11Solucao.Exercicio9();
            //Ficha11Solucao.Exercicio10();
            //Ficha11Solucao.Exercicio11();
            //Ficha11Solucao.Exercicio12();
            //Ficha11Solucao.Exercicio13();
            //Ficha11Solucao.Exercicio14();
            //Ficha11Solucao.Exercicio15();
            //Ficha11Solucao.Exercicio16();
            //Ficha11Solucao.Exercicio17();
            //Ficha11Solucao.Exercicio18();

            //Ficha12Solucao.Exercicio1();
            //Ficha12Solucao.Exercicio2();
            //Ficha12Solucao.Exercicio3();
            //Ficha12Solucao.Exercicio4();
            //Ficha12Solucao.Exercicio5();
            //Ficha12Solucao.Exercicio6();
            //Ficha12Solucao.Exercicio7();
            //Ficha12Solucao.Exercicio8();
            //Ficha12Solucao.Exercicio9();
            //Ficha12Solucao.Exercicio10();
            //Ficha12Solucao.Exercicio11();
            //Ficha12Solucao.Exercicio12();
            //Ficha12Solucao.Exercicio13();
            //Ficha12Solucao.Exercicio14();
            //Ficha12Solucao.Exercicio15();

            //Ficha13Solucao.Calculadora();
            //Ficha13Solucao.Forca();
            //Ficha13Solucao.PalavraRandom();

            //Ficha14Solucao.Exercicio1();
            //Ficha14Solucao.Exercicio2();
            //Ficha14Solucao.Exercicio3();
            //Ficha14Solucao.Exercicio4();
            //Ficha14Solucao.Exercicio5();
            //Ficha14Solucao.Exercicio6();

            //Ficha15Solucao.Exercicio1();
            //Ficha15Solucao.Exercicio2();
            //Ficha15Solucao.Exercicio3();
            //Ficha15Solucao.Exercicio4();
            //Ficha15Solucao.Exercicio5();
            //Ficha15Solucao.Exercicio6();
            //Ficha15Solucao.Exercicio7();
            //Ficha15Solucao.Exercicio8();
            //Ficha15Solucao.Exercicio9();

            //Ficha16Solucao.Exercicio1();
            //Ficha16Solucao.Exercicio2();
            //Ficha16Solucao.Exercicio3();
            //Ficha16Solucao.Exercicio4();
            //Ficha16Solucao.Exercicio5();
            //Ficha16Solucao.Exercicio6();
            //Ficha16Solucao.Exercicio7();
            //Ficha16Solucao.Exercicio8();

            //Ficha17Solucao.Exercicio1();
            //Ficha17Solucao.Exercicio2();
            //Ficha17Solucao.Exercicio3();
            //Ficha17Solucao.Exercicio4();
            //Ficha17Solucao.Exercicio5();
            //Ficha17Solucao.Exercicio6();
            //Ficha17Solucao.Exercicio7();

            //Testes.Testes.Summarize();

            Car p1 = new Car("Peugeut", "208", 2007);
            Car p2 = new Car("Ferrari", "FXX", 2018);
            Console.WriteLine($"{p1.GetBrand()}-{p1.GetYear()}-{p1.GetModel()}");
            Console.WriteLine($"{p2.GetBrand()}-{p2.GetYear()}-{p2.GetModel()}");

            Car1 p3 = new Car1("Peugeut", "208", 2007);
            Car1 p4 = new Car1("Ferrari", "FXX", 2018);
            Console.WriteLine($"{p3.brand} {p3.model} {p3.year}");
            Console.WriteLine($"{p4.brand} {p4.model} {p4.year}");

            Products p5 = new Products("Banana", 1.98, Types.Fruit);
            Console.WriteLine($"{p5.GetName()} - {p5.GetPrice()} - {p5.GetType()}");

            Products1 p6 = new Products1("Banana", 1.98, Types.Fruit);
            Console.WriteLine($"{p6.name} - {p6.price} - {p6.type}");

            Player1 player1 = new Player1("Renaldo", 42, 1.65f, 20, Sponsor.Nyka);
            Console.WriteLine($"{player1.GetName()} - {player1.GetAge()} - {player1.GetHeight()} - {player1.GetWeight()} - {player1.GetSponsor()} - {player1.GetIMC()}");

            Player2 player2 = new Player2("Messias", 39, 2.50f, 98, Sponsor.Acliclas);
            Console.WriteLine($"{player2.name} - {player2.age} - {player2.height} - {player2.weight} - {player2.sponsor} - {player2.imc}");
        }
    }
}
