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
//demo.TryCatch();


Console.WriteLine("Podaj bok kwadratu:");
string input = Console.ReadLine();

int side = int.Parse(input);

//if sprawdza warunek w nawiasie i jeśli jest on prawdziwy (true), to wykonuje się blok kodu pod nim
if (side > 0)
{
    Console.WriteLine($"Kwadrat ma obwód: {side*4}");
}
// jeśli poprzedni warunek nie jest spełniony, to sprawdzany jest kolejny if
// else if - może występować wielokrotne
else if (side < 0)
{
    Console.WriteLine("Nie mogę policzyć obwodu z ujemnego rozmiaru");
}
//else - wykonuje blok kodu w każdym innym przypadku
else
{
    Console.WriteLine("Kwadrat nie istnieje");
}


//jeżeli używany else jako łącznik ifów, to tylko jeden blok kodu zostanie wykonany i sprzwdzanie warunków zakończy się w przypadku wejścia w któryś z bloków
//jeżeli nie używany else, to każdy if będzie traktowany osobno i warunek będzie sprzwdzany niezależnie
//wniosek else jest też łącznikiem między kolejnymi if'ami

if (side != 0)
{
    Console.WriteLine("Bok jest różny od 0");
}
if (side == 0)
{
    Console.WriteLine("Bok jest równy 0");
}


bool result = side == 0; //== - porównanie
     result = side != 0; //!= - nierówność
     result = side > 0; //> - większe
     result = side < 0;//< - mniejsze
     result = side >= 0;//>= - większe bądź równe
     result = side <= 0;//<= - mniejsze bądź równe

     result = side > 0 || side < 0; // || - logiczne lub (OR)
     result = side > 0 && side < 10; // && - logiczne i (AND)

if(side > 0 && side <= 10)
{
    Console.WriteLine("Bok kwadratu jest z przedziału (0;10>");
}

//! - negacja - zaprzeczenie tego co występuje po wykrzykniku
if (!(side >= 5 && side < 8))
{
    Console.WriteLine("Bok kwadratu jest spoza przedziału <5;8)");
}