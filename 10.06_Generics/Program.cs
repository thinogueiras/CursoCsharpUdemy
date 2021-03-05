using Generics.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            var path = Console.ReadLine();
            
            try
            {
                using (var sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(' ');
                        var name = line[0];
                        var instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine($"\nTotal users: {set.Count}"); // Retorna a quantidade de elementos adicionados no conjunto
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);                
            }
        }
    }
}
