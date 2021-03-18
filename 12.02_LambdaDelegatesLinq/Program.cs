using LambdaDelegatesLinq.Services;
using System;

namespace LambdaDelegatesLinq
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            var a = 10.0;
            var b = 12.0;

            var result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            result = CalculationService.Max(a, b);
            Console.WriteLine(result);

            result = CalculationService.Square(a);
            Console.WriteLine(result);

            Console.WriteLine("\nDELEGATES ABAIXO");

            BinaryNumericOperation op = CalculationService.Max;
            result = op(a, b);
            Console.WriteLine(result);

            op = new BinaryNumericOperation(CalculationService.Sum);
            result = op.Invoke(a, b);
            Console.WriteLine(result);            

            Console.ReadLine();
        }
    }
}
