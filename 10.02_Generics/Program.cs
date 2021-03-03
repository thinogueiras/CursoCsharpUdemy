using Generics.Entities;
using Generics.Services;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();

            Console.Write("Enter N: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var vector = Console.ReadLine().Split(',');
                var name = vector[0];
                var price = double.Parse(vector[1]);
                list.Add(new Product(name, price));
            }

            var calculationService = new CalculationService();

            var max = calculationService.Max(list);

            Console.WriteLine("\nMax:");
            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
