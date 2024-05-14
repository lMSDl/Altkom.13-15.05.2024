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
//demo.While();


bool success;
float floatValue;

//do-while - sprawdza warunek PO wykonaniu ciała - zapewnia, że zostanie ono wykonane co najmniej raz
//pozwala to wyeliminować inicjalizację zminnych przed wejściem do pętli
do
{
    Console.WriteLine("Podaj liczbę:");
    string stringValue = Console.ReadLine();

    success = float.TryParse(stringValue, out floatValue);
} while (!success);  //w przypadku do-while na końcu występuje średnik ;


Console.WriteLine($"Twoja liczba to {floatValue}");
