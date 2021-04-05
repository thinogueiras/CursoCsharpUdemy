using LambdaDelegatesLinq.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            var path = Console.ReadLine();

            var list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    var fields = sr.ReadLine().Split(',');
                    var name = fields[0];
                    var price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = $ " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
