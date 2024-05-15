using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Line : Shape1D
    {
        public Line(float width) : base("odcinek", width)
        {
        }
    }
}
