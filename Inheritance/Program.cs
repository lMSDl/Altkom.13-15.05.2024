using Inheritance.Models;
using System;
using System.Collections.Generic;

/*Shape shape = new Shape("X");


Shape1D shape1D = new Shape1D("linia", 15);

Shape2D shape2D = new Shape2D("prostokąt", 10, 60);*/



Circle circle = new Circle(4);

Square square = new Square(8);

Shape2D triangle = new Triangle(10, 10, 90);
Shape rectangle = new Rectangle(13, 16);


List<Shape2D> shape2Ds = new List<Shape2D>();

shape2Ds.Add(triangle);
shape2Ds.Add(square);
shape2Ds.Add(circle);
//shape2Ds.Add(rectangle);

foreach (var item in shape2Ds)
{
    Console.WriteLine( item.GetName());
    Console.WriteLine( item.CalculateArea() );
}