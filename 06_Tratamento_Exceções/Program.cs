using System;

namespace Tratamento_de_Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var n1 = int.Parse(Console.ReadLine());
                var n2 = int.Parse(Console.ReadLine());

                var result = n1 / n2;

                Console.WriteLine("\n" + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }            
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números!!!");
            }
            finally
            {                
                Console.WriteLine("Encerrando a aplicação....");
            }            
        }
    }
}
