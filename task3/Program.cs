using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CalculatorOnPolishNotation calc = new CalculatorOnPolishNotation(input);
            Console.Write(calc.Calculate());
        }
    }
}