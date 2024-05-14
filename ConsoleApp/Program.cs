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
//demo.DoWhile();


//I - inicjalizacja pętli - wykonuje się tylko raz na początku
//II - warunek kontynuacji pętli - wykonuje się przed każdym wykonaniem ciała
//III - ciało pętli
//IV - akcja po wykonaniu ciała - najczęsciej inkrementacja licznika

//for(I; II; IV)
//{
//  III
//}

for (int i = 0; i < 5; i++ /*i += 1*/)
{
    Console.WriteLine(i);
}
Console.WriteLine("---");


//pętla nieskończona - odpowiednik while(true)
/*for (; ; )
{
    Console.WriteLine("*");
}*/


int value = 5;
for (; value > 0; value -= 2)
{
    Console.WriteLine(value);
}
Console.WriteLine("---");

value = 0;
for (; value < 5;)
{
    Console.WriteLine(value++); //wartość wzrasta po wyświetleniu
}
Console.WriteLine("---");

value = 0;
for (; value < 5;)
{
    Console.WriteLine(++value); //wartość wzrasta przed wyświetleniem
}
Console.WriteLine("---");

string input = Console.ReadLine();
string[] splittedString = input.Split();

for(int i = splittedString.Length - 1; i >= 0; i--)
{
    Console.WriteLine(splittedString[i]);
}
