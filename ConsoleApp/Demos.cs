using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Demos
    {
        public void Strings()
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
        public void Numbers()
        {
            { //zakres życia zmiennych ogranicają klamerki (niezależnie od tego czy oznaczają one początek/koniec metody czy po prostu bloku kodu jak tutaj)
                int a = 11;
                int b = 4;

                int c = a + b;
                Console.WriteLine($"{a} + {b} = {c}");
                c = a - b;
                Console.WriteLine($"{a} - {b} = {c}");
                c = a * b;
                Console.WriteLine($"{a} * {b} = {c}");
                c = a / b; // część dziesiętna jest ucięta
                Console.WriteLine($"{a} / {b} = {c}");
                c = a % b; //reszta z dzielenia
                Console.WriteLine($"{a} % {b} = {c}");
            }

            {
                float a = 11f;
                float b = 4.0f;
                float c = a + b;
                Console.WriteLine($"{a} + {b} = {c}");
                c = a - b;
                Console.WriteLine($"{a} - {b} = {c}");
                c = a * b;
                Console.WriteLine($"{a} * {b} = {c}");
                c = a / b;
                Console.WriteLine($"{a} / {b} = {c}");
            }

            int intA = 5;
            int intB = 7;

            //aby wynik był poprawny przy dzieleniu dwóch intów należy jako pierwszą operację "przekształcić" int na float
            //możemy to zrobić poprzez wykonanie jako pierwszą operację mnożenia przez typ o większej prezycji
            float floatC = 1f * intA / intB;
            Console.WriteLine(floatC);

            //lub poprzez rzutowanie (czyli potraktowanie jednego typu jako inny (podany w nawiasie))
            floatC = (float)intA / intB;
            Console.WriteLine(floatC);

            //kolejność działań zgodna z zasadami matematyki
            floatC = intA + intA * intA;
            Console.WriteLine($"{intA} + {intA} * {intA} = {floatC}");
            floatC = (intA + intA) * intA;
            Console.WriteLine($"({intA} + {intA}) * {intA} = {floatC}");



            Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
            Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
            Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

            Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
            Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
            Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

            Console.WriteLine(5 / 3.3f); //f - float
            Console.WriteLine(5 / 3.3d); //d - double
            Console.WriteLine(5 / 3.3m); //m - decimal

            //Math to klasa zawierające funkcje przydatne w obliczeniach matematycznych
            //domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(3.5));

            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));


            floatC = 13.1111f;


            //formatowanie liczb
            // po : wstawiamy format liczby. Może być on szablonem, gdzie 0-9 oznacza zastąpienie brakującej wartości, a # wstawienie wartości gdy jest ona różna od 0
            Console.WriteLine($"{floatC:00#.0##}");
            //możemy też zastosować predefiniowane formaty: f2 oznacza zachowanie 2 miejsce po przecinku
            Console.WriteLine($"{1f / 3f:f2}");


            Console.WriteLine("Podaj pierwszy bok kwadratu:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi bok kwadratu");
            string input2 = Console.ReadLine();

            /*int sideA = int.Parse(input1);
            int sideB = int.Parse(input2);*/

            float sideA = float.Parse(input1);
            float sideB = float.Parse(input2);

            float area = sideA * sideB;
            Console.WriteLine($"Pole to {area}");

        }


        public void ShowTime(int seconds)
        {
            int variable = 60 * 60 * 24;
            int days = seconds / variable;
            seconds = seconds - (days * variable);

            variable = variable / 24;
            int hours = seconds / variable;
            seconds = seconds - (hours * variable);

            variable /= 60; //multiplier = multiplier / 60;
            int minutes = seconds / variable;
            seconds -= (minutes * variable); //seconds = seconds - (minutes * multiplier);

            Console.WriteLine($"{days}.{hours:0#}:{minutes:0#}:{seconds:0#}");
        }

        public void Arrays()
        {
            int a = 5;
            int b = 10;
            int c = 15;

            //deklaracja tablicy przechowyjące dane typu int
            //[] - tablica
            int[] intArray;


            //inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
            //tablica wypełniana jest wartościami domyślnymi zadeklarowanego typu (dla int jest to 0)
            intArray = new int[3];


            //tablice są indeksowane od 0 (minimalny indeks)
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            //maksymalny indeks tablicy to rozmiar minus 1 (3 - 1 = 2)
            Console.WriteLine(intArray[intArray.Length - 1]);


            intArray[0] = a;
            intArray[1] = 11;
            intArray[2] = c + b;

            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[0]);

            Console.WriteLine($"Tablica ma rozmiar {intArray.Length}");

            string[] stringArray = new string[2];

            Console.WriteLine("Podaj pierwszy bok prostokąta:");
            stringArray[0] = Console.ReadLine();
            Console.WriteLine("Podaj drugi bok prostokąta:");
            stringArray[1] = Console.ReadLine();

            intArray[0] = int.Parse(stringArray[0]);
            intArray[1] = int.Parse(stringArray[1]);

            Console.WriteLine($"Pole to: {intArray[0] * intArray[1]}");


            Console.WriteLine("Napisz coś:");
            string input = Console.ReadLine();

            //tablica zwracana jako rezultat wywołania metody
            //metoda split dzieli string na części wg wskazanego separatora
            //bez wskazania separatora dzieli po spacji
            string[] words = input.Split();


            Console.WriteLine($"Wpisałeś {words.Length} słów");
        }


        public void Lists()
        {
            //tworzymy nową listę. Lista po inicjalizacji jest pusta.
            List<string> strings = new List<string>();

            Console.WriteLine(strings.Count);


            //dodajemy nowy element do listy, rozmiar tablicy się zwiększa
            strings.Add("!");
            strings.Add("ala");
            strings.Add("kota");

            Console.WriteLine(strings.Count);

            //wstawiamy element na konkretny indeks listy - pozostałe ementy przesuwają się
            strings.Insert(2, "ma");

            Console.WriteLine(strings.Count);

            strings.Add("!");
            strings.Add("!");
            Console.WriteLine(strings.Count);

            //usuwamy element pod ostatnim indeksem - rozmiar listy się zmniejsza
            strings.RemoveAt(strings.Count - 1);

            //usuwamy element wg wartości - jeśli występuję więcej takich elementów, to usuwany jest pierwszy w kolejności
            strings.Remove("!");

            Console.WriteLine(strings.Count);

            //w listach odwołujemy się do elementów po indeksach (tak jak w tablicach)
            strings[strings.Count - 1] = "?";

            Console.WriteLine(strings[1]);

            //przekształcenie tablicy do listy
            strings = Console.ReadLine().Split().ToList();

            Console.WriteLine($"Lista ma rozmiar: {strings.Count}");
        }

        public void TryCatch()
        {
            Console.WriteLine("Podaj bok kwadratu:");
            string input = Console.ReadLine();

            //blok try-catch służy do obsługi wyjątków
            try //w try wpisujemy kod, w którym może wystąpić błąd (wyjątek)
            {
                int side = int.Parse(input);
                Console.WriteLine($"Pole: {side * side}; Obwód: {4 * side}");
            }
            catch //w catch wpisujemy co ma się stać jeśli wystąpi wyjątek. catch bez "parametru" przechwytuje dowolnego rodzaju wyjątki
            {
                Console.WriteLine("Coś poszło nie tak...");
            }

            Console.WriteLine("Podaj promień koła:");
            input = Console.ReadLine();
            try
            {
                int r = int.Parse(input);
                Console.WriteLine($"Pole: {Math.PI * r * r}; Obwód: {2 * Math.PI * r}");
            }
            catch (Exception e) //jeśli chcemy znać powód błędu, możemy zajrzeć do obiektu wyjątku deklarując typ i nazwę zmiennej wyjątku jako "parametr" catch
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Podaj wartość parzystą:");
            input = Console.ReadLine();
            try
            {
                int value = int.Parse(input);

                if (value % 2 != 0) //jeśli reszta z dzielenia przez 2 jest różna od 0 (czyli value nie jest podzielne przez 2)
                {
                    throw new ArgumentException("Wartość nie jest przysta");
                }
                //throw new Exception();

                Console.WriteLine($"Super!");
            }
            catch (ArgumentException e) //możemy definiować różne zachowania w zależności os typu wyjątku
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Nie można przekonwertować podanej wartości na int");
            }
            catch (Exception e) //definiujemy je od szczegółowego do ogólnego
            {
                Console.WriteLine($"Coś poszło nie tak: {e.Message}");
            }
        }
    }
}
