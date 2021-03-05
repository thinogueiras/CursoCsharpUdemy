using System;
using System.Collections.Generic;

namespace Generics.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students for course A? ");
            var n = int.Parse(Console.ReadLine());

            var hashSet01 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());                
                hashSet01.Add(x);
            }

            Console.Write("\nHow many students for course B? ");
            n = int.Parse(Console.ReadLine());

            var hashSet02 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                hashSet02.Add(x);
            }

            Console.Write("\nHow many students for course C? ");
            n = int.Parse(Console.ReadLine());

            var hashSet03 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                hashSet03.Add(x);
            }

            var all = new HashSet<int>(hashSet01);
            all.UnionWith(hashSet02);
            all.UnionWith(hashSet03);            

            Console.WriteLine($"\nTotal students: {all.Count}");            
        }
    }
}
