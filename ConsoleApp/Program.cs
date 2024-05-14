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
//demo.For();

string input = Console.ReadLine();
string[] splittedString = input.Split();

//foreach zastępuje poniższy sposób iteracji po tablicy przy założeniu, że iterujemy od początku do końca tablicy
for (int i = 0; i < splittedString.Length; i++)
{
    string word = splittedString[i];

    Console.WriteLine(word);
}

//foreach - pozwala przejsc po wszystkich elementach tablicy
foreach (string word in splittedString)
{
    Console.WriteLine(word);
}


input = Console.ReadLine();
splittedString = input.Split();

int[] intValues = new int[splittedString.Length];
for(int i = 0; i < splittedString.Length; i++)
{
    intValues[i] = int.Parse(splittedString[i]);
}

int counter = 0;
foreach (int value in intValues)
{
    if (value % 2 == 0)
        counter++;
}
Console.WriteLine($"Wprowadziłeś {counter} liczb parzystych");


List<int> intList = new List<int>();
foreach (string s in splittedString)
{
    intList.Add(int.Parse(s));
}

foreach(int value in intList)
{
    if(value % 2 == 0)
        continue; //przerywa aktualne wykonywanie ciałą i przechodzi do kolejnej iteracji

    if(value == 23)
    {
        Console.WriteLine("Znalazłem wartość 23!");
        break; //przerywa wykonywanie pętli
    }
}