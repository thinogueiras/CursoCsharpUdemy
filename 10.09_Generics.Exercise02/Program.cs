using Generics.Exercise02.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Generics.Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                var path = Console.ReadLine();                

                using (var fs = new FileStream(path, FileMode.Open))
                using (var sr = new StreamReader(fs))
                {
                    var dictionary = new Dictionary<string, int>();                    

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(',');
                        var name = line[0];
                        var quantity = int.Parse(line[1]);
                        var countVotes = new CountVotes(name, quantity);                                 

                        if (dictionary.ContainsKey(countVotes.Name))
                        {
                            dictionary[countVotes.Name] += quantity;
                        }
                        else
                        {
                            dictionary[countVotes.Name] = quantity;
                        }
                    }

                    Console.WriteLine();
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    Console.WriteLine();
                }
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }       
    }
}
