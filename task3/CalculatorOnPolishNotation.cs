using System;
using System.Collections.Generic;
using System.Globalization;

namespace task3
{
    public class CalculatorOnPolishNotation
    {
        private string polishNotationInitText;
        private Stack<double> calculatedNumbers;

        public CalculatorOnPolishNotation(string polishNotationInitText)
        {
            this.polishNotationInitText = polishNotationInitText;
            this.calculatedNumbers = new Stack<double>();
        }

        public void Clear()
        {
            polishNotationInitText = String.Empty;
            calculatedNumbers = new Stack<double>();
        }

        public double Calculate()
        {
            foreach (var token in polishNotationInitText.Split())
            {
                PerformOperation(token);
            }
            return calculatedNumbers.Pop();
        }
        
        private void PerformOperation(string token)
        {
            if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
            {
                calculatedNumbers.Push(number);
                return;
            }
            
            try
            {
                double x1 = calculatedNumbers.Pop();
                double x2 = calculatedNumbers.Pop();
                switch (token)
                {
                    case "+":
                        calculatedNumbers.Push(x1 + x2);
                        break;
                    case "-":
                        calculatedNumbers.Push(x2 - x1);
                        break;
                    case "×":
                    case "*":
                        calculatedNumbers.Push(x1 * x2);
                        break;
                    case "/":
                        calculatedNumbers.Push(x2 / x1);
                        break;
                    default:
                        throw new InvalidOperationException($"The operation {token} is not supported.");
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.Write($"{ex.Message}\n{ex.StackTrace}");
                System.Environment.Exit(1);
            }
        }
    }
}