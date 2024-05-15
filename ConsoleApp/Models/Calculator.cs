using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Calculator
    {
        public Calculator()
        {
            Result = 0;
        }

        public Calculator(double initialValue)
        {
            Result = initialValue;
        }
        public double Result { get; private set; }

        public void Add(double value)
        {
            Result = Result + value;
        }
        public void Substract(double value)
        {
            Result = Result - value;
        }
        public void Multiply(double value)
        {
            Result = Result * value;
        }
        public void Divide(double value)
        {
            Result = Result / value;
        }
    }
}
