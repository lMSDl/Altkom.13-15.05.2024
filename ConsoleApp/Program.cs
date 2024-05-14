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


Console.WriteLine("Podaj bok kwadratu:");
string input = Console.ReadLine();
int side;
bool parseSuccess = int.TryParse(input, out side);

if (!parseSuccess)
{
    Console.WriteLine("Błędna wartość");
}
else
{
    //switch - przyjmuje parametr, kóry jest porównywany z listą przypadków (case)
    switch (side)
    {
        //case - rozpatrywany przypadek
        //wiele case'ow może być przypisanych do tego samego kodu
        case > 0:
            //kod wykonywany jest od case do break - nie ma potrzeby stosowaniea klamerek {}
            //case musi kończyć się instrukją break - przerywająca wykonywanie swticha
            Console.WriteLine($"Kwadrat ma obwód: {side * 4}");
            break;
        case < 0:
            Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
            break;
        //default - odpowiedniek else, czyli wykonanie kodu, jeśli nie znalezioni odpowiedniego case
        default:
            Console.WriteLine("Kwadrat nie istnieje");
            break;
    }
}