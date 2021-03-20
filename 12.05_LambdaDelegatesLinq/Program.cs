using LambdaDelegatesLinq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine("Lista de produtos");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Func<Product, string> func = p => p.Name.ToUpper();

            //var result = list.Select(func);
            var result = list.Select(p => p.Name.ToUpper());
            //var result = list.Select(NameUpper);            

            Console.WriteLine("\nLista de produtos - Caixa Alta");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}
