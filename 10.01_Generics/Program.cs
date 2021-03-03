using Generics.Exercise_01.Entities;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var printServiceInt = new PrintService<int>();

            Console.Write("How many values? ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                printServiceInt.AddValue(x);
            }

            Console.WriteLine();
            printServiceInt.Print();

            Console.Write("First: " + printServiceInt.FirstValue());

            Console.WriteLine();

            var printServiceString = new PrintService<string>();

            Console.Write("\nHow many text? ");
            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var y = Console.ReadLine();
                printServiceString.AddValue(y);
            }

            Console.WriteLine();
            printServiceString.Print();

            Console.Write("First: " + printServiceString.FirstValue());

            Console.ReadLine();
        }
    }
}
