using System;
using SpecFlowCalculator;

namespace InClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calc = new Calculator();
            Console.WriteLine("What numbers would you like to add? Press enter after each one.");
            calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
            calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"result: {calc.Add()}");
        }
    }
}
