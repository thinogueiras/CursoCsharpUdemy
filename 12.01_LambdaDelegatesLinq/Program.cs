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

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            list.Add(new Product("Mochila Dell", 120.00));

            //list.Sort(CompareProducts);

            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //list.Sort(comp); // Sort necessita que a classe Product implemente a interface IComparable
                             // CompareProducts é uma delegate - Função Sort está recebendo com argumento uma referência para uma função

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Expressão lambda diretamente no método Sort

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
