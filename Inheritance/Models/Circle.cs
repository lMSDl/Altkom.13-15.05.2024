using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Circle : Shape2D
    {
        public Circle(float radius) : base("okrąg", 2 * radius, 2 * radius)
        {
        }


        //override - implementujemy metodę abstrakcyjną
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(Width / 2, 2));
        }
    }
}
