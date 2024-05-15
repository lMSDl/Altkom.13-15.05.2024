using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //: - dziedziczenie - klasa Shape1D dziedziczy cechy Shape i dodaje swoje własne zachowania i stany
    internal abstract class Shape1D : Shape
    {
        public float Width { get; private set; }

        //base - odwołanie się do konstruktora z klasy bazowej
        public Shape1D(string name, float width) : base(name)
        {
            Width = width;
        }

        //override - nadpisujemy metodę z klasy bazowej (czyli tej po której dziedziczymy)
        public override string GetName()
        {
            return $"1D: {Name}";
        }
    }
}
