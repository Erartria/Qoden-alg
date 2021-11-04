using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IEnumerable<KeyValuePair<string,string>> chart = new WordFrequencyChartGenerator(input).GenerateChart(10);
            foreach (var keyValuePair in chart)
            {
                Console.WriteLine($"{keyValuePair.Key} {keyValuePair.Value}");
            }
        }
    }
}