using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = "c:\\test1_csharp.txt"; // Ao utilizar a classe File, o arquivo deve existir antes da execução do programa
            var targetPath = "c:\\test2_csharp.txt"; // O arquivo foi criado após a execução do programa

            try
            {
                var lines = File.ReadAllLines(sourcePath);
                using (var sw = File.AppendText(targetPath))
                {
                    foreach (var line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

                var newLines = File.ReadAllLines(targetPath);
                var count = 1;

                foreach (var newLine in newLines)
                {
                    Console.WriteLine($"Line: {count} {newLine}");
                    count++;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        void TesteUsing01()
        {
            var path = "c:\\test1_csharp.txt";

            try
            {
                using (var fs = new FileStream(path, FileMode.Open))
                using (var sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        var lines = sr.ReadLine();
                        Console.WriteLine(lines);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void TestFileStreamAndStreamReader03()
        {
            var path = "c:\\test_csharp.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    var lines = sr.ReadLine();
                    Console.WriteLine(lines);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        void TestFileStreamAndStreamReader02()
        {
            var path = "c:\\test_csharp.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                var lines = sr.ReadLine();
                Console.WriteLine(lines);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        void TestFileStreamAndStreamReader01()
        {
            var path = "c:\\test_csharp.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate);
                sr = new StreamReader(fs);
                var lines = sr.ReadLine();
                Console.WriteLine(lines);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        void TestFileAndFileInfo()
        {
            var sourcePath = @"c:\nomes.txt";
            var targetPath = @"c:\nomes2.txt";

            try
            {
                var fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                var lines = File.ReadAllLines(sourcePath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Message);
            }
        }

    }
}
