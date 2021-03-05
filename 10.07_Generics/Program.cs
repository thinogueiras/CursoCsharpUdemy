using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "999999999";
            cookies["phone"] = "123456789";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine("\nALL COOKIES:");

            foreach (var item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
