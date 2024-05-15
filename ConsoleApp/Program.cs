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