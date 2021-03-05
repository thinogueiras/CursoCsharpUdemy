using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSetString = new HashSet<string>();

            hashSetString.Add("TV");
            hashSetString.Add("Notebook");
            hashSetString.Add("Tablet");

            Console.WriteLine(hashSetString.Contains("Notebook"));

            foreach (var item in hashSetString)
            {
                Console.WriteLine(item);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };

            SortedSet<int> b = new SortedSet<int>() { 3, 1, 5, 6, 7, 8, 9, 10 };

            PrintColletion(a);

            // union

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintColletion(c);

            // intersection

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintColletion(d);

            // difference

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintColletion(e);
            
        }

        static void PrintColletion<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
