using LambdaDelegatesLinq.Services;
using System;

namespace LambdaDelegatesLinq
{
    delegate double BinaryNumericOperation01(double n1, double n2);
    delegate void BinaryNumericOperation02(double n1, double n2);

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

            BinaryNumericOperation01 op01 = CalculationService.Max;
            result = op01(a, b);
            Console.WriteLine(result);

            op01 = new BinaryNumericOperation01(CalculationService.Sum);
            result = op01.Invoke(a, b);
            Console.WriteLine(result);

            Console.WriteLine("\nNEW DELEGATES ABAIXO");

            BinaryNumericOperation02 op02 = CalculationService.ShowSum;
            op02 += CalculationService.ShowMax;

            op02.Invoke(a, b);

            Console.ReadLine();
        }
    }
}
