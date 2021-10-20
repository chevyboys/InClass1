using System;
using System.Diagnostics;

namespace SpecFlowCalculator
{
    public class Calculator
    {
 
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int result { get; set; }

        public int Add()
        {
            return (int)(FirstNumber + SecondNumber);
        }
        public int Subtract()
        {
            return (int)(FirstNumber - SecondNumber);
        }
        public int Multiply()
        {
            return (int)(FirstNumber * SecondNumber);
        }

        public float Divide()
        {
            if (SecondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            else return (int) (FirstNumber / SecondNumber);
        }

        public int Remainder()
        {
            return (int) (FirstNumber % SecondNumber);
        }
    }
}