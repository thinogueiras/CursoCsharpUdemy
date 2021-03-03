using Generics.Entities;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Maria", "maria@gmail.com");
            Client b = new Client("Alex", "maria@gmail.com");

            Console.WriteLine(a.Equals(b)); // Compara o conteúdo
            Console.WriteLine(a == b); // Compara a referência na memória
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
