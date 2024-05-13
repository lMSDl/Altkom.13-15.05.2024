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