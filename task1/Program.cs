using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(),out var n);
            String inputString = Console.ReadLine();

            HashTable hashTable = new HashTable(n);
            foreach (var substring in inputString.Split(' '))
            {
                int.TryParse(substring, out var number);
                hashTable.Insert(number);
            }
            Console.WriteLine(hashTable);
        }
    }
}
