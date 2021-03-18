using LambdaDelegatesLinq.Entities;
using System;
using System.Collections.Generic;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(ProductTest);
            list.RemoveAll(p => p.Price >= 100.00);
            foreach (Product p in list)
            {
                Console.WriteLine(p); // Mostra os produtos removidos
            }

            Console.ReadLine();
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
