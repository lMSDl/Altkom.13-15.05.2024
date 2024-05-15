
namespace ConsoleApp.Models
{
    public class Calculator
    {
        private double _initialValue;

        public Calculator() : this(0)
        {
        }

        public Calculator(double initialValue)
        {
            Result = initialValue;
            _initialValue = Result;
        }

        public double Result { get; private set; }
        public int OperationCounter { get; private set; }

        public void Add(double value)
        {
            Result = Result + value;
            IncreaseOperationCounter();
        }

        public void Substract(double value)
        {
            Result = Result - value;
            IncreaseOperationCounter();
        }
        public void Multiply(double value)
        {
            Result = Result * value;
            IncreaseOperationCounter();
        }
        public void Divide(double value)
        {
            Result = Result / value;
            IncreaseOperationCounter();
        }

        private void IncreaseOperationCounter()
        {
            OperationCounter++;
        }

        public void Clear()
        {
            Result = _initialValue;
            IncreaseOperationCounter();
        }
    }
}
