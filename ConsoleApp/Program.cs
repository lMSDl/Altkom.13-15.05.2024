using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

//Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.ShowTime(11940);
//demo.Arrays();
//demo.Lists();
//demo.TryCatch();
//demo.Ifs();
//demo.Switch();

//musimy zainicjalizować zmienną wartością false, żeby pętla się wykonała chociaż raz
bool success = false;

//musimy zainicjalizować zmienną, ponieważ istnieje szansza, że pętla się nie wykona i zmienna nie zostanie zainicjalozowana, a za pętlą ma być użyta
float floatValue = default; //default - inicjalizuje wartością domyślną dla danego typu (dla float to 0)

//while - pętla która trwa gdy jej parametr jest true, parametr jest sprawdzany PRZED każdym wejściem do ciała pętli
// jeśli przy pierwszym wejściu parametr będzie false, to pętla się nigdy nie wykona
//while(true) = pętla nieskończona
while (!success) 
{
    Console.WriteLine("Podaj liczbę:");
    string stringValue = Console.ReadLine();

    success = float.TryParse(stringValue, out floatValue);
}


Console.WriteLine($"Twoja liczba to {floatValue}");