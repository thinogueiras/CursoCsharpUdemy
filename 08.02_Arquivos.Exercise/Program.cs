using System;
using System.Globalization;
using System.IO;

namespace Arquivos.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                var pathFile = @"C:\ExerciseCsharp_Arquives\Input\produtos.csv";
                var directory = Directory.CreateDirectory(@"C:\ExerciseCsharp_Arquives\Output");
                var newPathFile = @"C:\ExerciseCsharp_Arquives\Output\produtosEdit.csv";

                //var directory = Directory.CreateDirectory(pathFile.Substring(0, 26) + @"\Output");
                //var newPathFile = directory + @"\produtosEdit.csv";

                using (var fs1 = new FileStream(pathFile, FileMode.Open))
                using (var sr = new StreamReader(fs1))
                using (var fs2 = new FileStream(newPathFile, FileMode.OpenOrCreate))
                using (var sw = new StreamWriter(fs2))
                {                     
                    while (!sr.EndOfStream)
                    {
                        var lines = sr.ReadLine().Split(',');                        
                        var price = double.Parse(lines[1], CultureInfo.InvariantCulture);
                        var quantity = int.Parse(lines[2]);
                        var sum = price * quantity;
                        sw.WriteLine($"{lines[0]},{sum.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    Console.WriteLine("New file successfully generated");
                }
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
