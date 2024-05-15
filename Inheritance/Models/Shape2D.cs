using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal abstract class Shape2D : Shape1D
    {
        public float Height { get; private set; }

        public Shape2D(string name, float width, float height) : base(name, width)
        {
            Height = height;
        }


        //override - zmieniamy zachowanie metody
        public override string GetName()
        {
            return $"2D: {Name}";
        }

        //metoda abstrakcyjne - nie posiadająca implementacji. Implementacja musi zostać zapewniona w klasach dziedziczących
        //metoda abstrakcyjna musi znajdować się w klasie abstrakcyjnej
        public abstract float CalculateArea();
    }
}
