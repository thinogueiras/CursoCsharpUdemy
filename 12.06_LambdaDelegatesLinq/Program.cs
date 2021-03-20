using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 8, 3, 6, 5, 4, 9, 2, 7};

            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10)
                .OrderByDescending(x => x);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
