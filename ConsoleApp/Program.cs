using ConsoleApp;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

//StringDemo myDemo = new StringDemo();
//myDemo.Run();

//NumbersDemo numbersDemo = new NumbersDemo();
//numbersDemo.Run();
//numbersDemo.ShowTime(119345);


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