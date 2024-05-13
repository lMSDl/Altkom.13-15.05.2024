using System;



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