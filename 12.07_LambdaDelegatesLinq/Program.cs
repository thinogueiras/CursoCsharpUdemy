using LambdaDelegatesLinq.Entities;
using System;
using System.Linq;
using System.Collections.Generic;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            var c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            var c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            var listProducts = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.00, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };            

            var r1 = listProducts.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = listProducts.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

            var r3 = listProducts.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = listProducts.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = listProducts.First();
            Console.WriteLine("First test1: " + r6);
            var r7 = listProducts.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            Console.WriteLine();

            var r8 = listProducts.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = listProducts.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            Console.WriteLine();

            var r10 = listProducts.Max(p => p.Price);
            Console.WriteLine("Max Price: " + r10);

            var r11 = listProducts.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            var r12 = listProducts.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = listProducts.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r13);

            var r14 = listProducts.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Preço já existente no Select
            Console.WriteLine("Category 5 Average prices: " + r14);

            var r15 = listProducts.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); // Tratando possível coleção vazia
            Console.WriteLine("Category 1 aggretate sum: " + r15);

            Console.WriteLine();

            var r16 = listProducts.GroupBy(p => p.Category);
            foreach (var group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
                        
        }
    }
}
