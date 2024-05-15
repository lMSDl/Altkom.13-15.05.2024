using ConsoleApp;
using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

Demos demo = new Demos();
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
//demo.Foreach();
//demo.AverageTry();


Person p;
p = new Person("Ewa");

//p.SetName("Ewa");
p.LastName = "Ewowska";
Console.WriteLine( p.GetName() );
Console.WriteLine(p.Age);

Console.WriteLine( p.GenerateBio());


/* Tworzenie pierwszego autora "Jan Nowak" */
Person person1 = new Person("Jan");
person1.LastName = "Nowak";

/* Tworzenie drugiego autora "Jan Nowak" */
Person person2 = new Person("Kamil");
person2.LastName = "Kowalski";

/* Tworzenie pierwszej książki */
Book book1 = new Book();
book1.Title = "Grunwald";
book1.Author = person1;

/* Tworzenie drugiej książki */
Book book2 = new Book();
book2.Title = "Miś uszatek";
book2.Author = person1;

/* Tworzenie trzeciej książki */
Book book3 = new Book();
book3.Title = "Muminki";
book3.Author = person2;

Library library = new Library();
library.Add(book1);
library.Add(book2);
library.Add(book3);
library.ShowBooks();