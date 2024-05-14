using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;

//Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.ShowTime(11940);
//demo.Arrays();
//demo.Lists();



Console.WriteLine("Podaj bok kwadratu:");
string input = Console.ReadLine();

//blok try-catch służy do obsługi wyjątków
try //w try wpisujemy kod, w którym może wystąpić błąd (wyjątek)
{
    int side = int.Parse(input);
    Console.WriteLine($"Pole: {side*side}; Obwód: {4*side}");
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
catch(Exception e) //jeśli chcemy znać powód błędu, możemy zajrzeć do obiektu wyjątku deklarując typ i nazwę zmiennej wyjątku jako "parametr" catch
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
catch(Exception e) //definiujemy je od szczegółowego do ogólnego
{
    Console.WriteLine($"Coś poszło nie tak: {e.Message}");
}