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


Person person = new Person();

person.SetName("Ewa");
person.Age = 50;
person.LastName = "Ewowska";
Console.WriteLine( person.GetName() );
Console.WriteLine(person.Age);