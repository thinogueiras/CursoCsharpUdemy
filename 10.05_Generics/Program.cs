using Generics.Entities;
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new HashSet<Product>();
            a.Add(new Product("TV", 900));
            a.Add(new Product("Notebook", 1200));

            var b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            var product = new Product("Notebook", 1200); // Objeto diferente do que foi inserido no conjunto - aponta para outra referência na memória / endereço de memória diferente

            Console.WriteLine(a.Contains(product)); // Retorna False se a classe Product não implementa os métodos GetHashCode e Equals

            var p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); // Retorna True, pois o tipo é struct e a comparação é feita por conteúdo e não por referência de memória, que sempre será diferente
        }
    }
}
