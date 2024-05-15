using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Square : Shape2D
    {
        public Square(float side) : base("kwadrat", side, side)
        {
        }


        //override - implementujemy metodę abstrakcyjną
        public override float CalculateArea()
        {
            return Height * Width;
        }
    }
}
