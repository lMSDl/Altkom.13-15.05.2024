using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Triangle : Shape2D
    {
        public float Angle { get; private set; }    

        public Triangle(float width, float height, float angle) : base("trójkąt", width, height)
        {
            Angle = angle;
        }


        //override - implementujemy metodę abstrakcyjną
        public override float CalculateArea()
        {
            return Height + Width * (float)Math.Cos(Angle);
        }
    }
}
