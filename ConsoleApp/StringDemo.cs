using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class StringDemo
    {

        public void Run()
        {
            Console.WriteLine("Hello, Paul!"); //Console.Write("\n");
                                               //; - średnik oznacza koniec instrukcji


            //deklaracja zmiennej lokalnej typu string (ciąg/łańcuch znaków) i nazwie helloVariable
            string helloVariable;

            //inicjalizację zmiennej - pierwsze przypisanie wartości
            helloVariable = "Hi";
            //nie możemy używać niezainicjalizowanych zmiennych

            Console.WriteLine(helloVariable);
            Console.WriteLine(helloVariable);

            //deklaracja z inicjalizacją
            string target = "World";
            Console.WriteLine(target);

            //zmiana wartości - każde kolejne przypisanie wartości
            target = Console.ReadLine();
            Console.WriteLine(target);

            Console.Write(helloVariable);
            Console.Write(" ");
            Console.WriteLine(target);

            string output;

            //łączenie stringów za pomocą operatora +
            output = helloVariable + " " + target + "!";

            Console.WriteLine(output);

            //ączenie stringów za pomocą funkcji string.Format
            string format = "{0} {1}!"; //wartości w nawiasach oznaczają indeks parametru, który ma być wstawiony w to miejsce
            output = string.Format(format, helloVariable, target); // pierwszy parametr to wygląd (format) stringa, a kolejne odpowiadają indeksom (od 0 )

            Console.WriteLine(output);

            output = string.Format(format, "Hello", "world");
            Console.WriteLine(output);

            //łączenie stringów wykorzystując interpolację (string interpolowany)
            output = $"{helloVariable} {target}!";
            Console.WriteLine(output);

            format = "Długość dotychczasowej zawartości zmiennej \"output\" to {0}";

            output = string.Format(format, output.Length);
            Console.WriteLine(output);

            output = string.Format(format, output.Count());
            Console.WriteLine(output);

            //stringów nie możemy edytować, żeby zmienić wartość należy wytworzyć nowego stringa i przypisać pod zmienną
            output = output.Replace("56", "57");
            Console.WriteLine(output);

            //zastąpienie części znaków - czułe na wielkość liter
            output = output.Replace("dotychczasowej", "tymczasowej");
            Console.WriteLine(output);

            output = output.Replace("TyMczaSowej", "dotychczasowej", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(output);

            //wycinanie "podstringów"
            output = output.Substring(output.Length - 14);
            Console.WriteLine(output);


            output = output.Substring(output.Length - 14, 8);
            Console.WriteLine(output);


            string someString = "ala ma kota";
            string anotherString = "Ala ma kota";

            bool isEqual;

            //= operator przypisania
            // == - operator porównania, dla string działa tak samo jak Equals
            isEqual = someString == anotherString;
            Console.WriteLine(isEqual);

            isEqual = someString.Equals(anotherString, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(isEqual);

            string name = Console.ReadLine();

            //usuwanie białych znaków z początku i/lub końca
            Console.WriteLine($"{name}");
            Console.WriteLine($"*{name}*");
            Console.WriteLine($"*{name.Trim()}*");
            Console.WriteLine($"*{name.TrimEnd()}*");
            Console.WriteLine($"*{name.TrimStart()}*");

            //usuwanie wskazanego znaku przez sparametryzowanie metody wskazanym znakiem
            Console.WriteLine($"*{name.Trim().Trim('ł')}*");

        }

    }
}
