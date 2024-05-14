using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;

//Demos demo = new Demos();
//demo.Strings();
//demo.Numbers();
//demo.ShowTime(11940);
//demo.Arrays();

//tworzymy nową listę. Lista po inicjalizacji jest pusta.
List<string> strings = new List<string>();

Console.WriteLine(strings.Count);


//dodajemy nowy element do listy, rozmiar tablicy się zwiększa
strings.Add("!");
strings.Add("ala");
strings.Add("kota");

Console.WriteLine(strings.Count);

//wstawiamy element na konkretny indeks listy - pozostałe ementy przesuwają się
strings.Insert(2, "ma");

Console.WriteLine(strings.Count);

strings.Add("!");
strings.Add("!");
Console.WriteLine(strings.Count);

//usuwamy element pod ostatnim indeksem - rozmiar listy się zmniejsza
strings.RemoveAt(strings.Count - 1);

//usuwamy element wg wartości - jeśli występuję więcej takich elementów, to usuwany jest pierwszy w kolejności
strings.Remove("!");

Console.WriteLine(strings.Count);

//w listach odwołujemy się do elementów po indeksach (tak jak w tablicach)
strings[strings.Count - 1] = "?";

Console.WriteLine(strings[1]);

//przekształcenie tablicy do listy
strings = Console.ReadLine().Split().ToList();

Console.WriteLine($"Lista ma rozmiar: {strings.Count}");