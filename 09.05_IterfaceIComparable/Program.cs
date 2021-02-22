using InterfaceIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\TestIComparable.txt";

            try
            {
                using (var streamReader = File.OpenText(path))
                {
                    var list = new List<Employee>();

                    while (!streamReader.EndOfStream)
                    {
                        list.Add(new Employee(streamReader.ReadLine()));
                    }

                    list.Sort();

                    foreach (var employee in list)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
