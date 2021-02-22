using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System;
using System.Globalization;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter contract data:");
            Console.Write("\nNumber: ");
            var number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            var contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            var numberOfInstallments = int.Parse(Console.ReadLine());

            var contract = new Contract(number, date, contractValue);

            var contractProccessing = new ContractProcessing(new PaypalPayment());

            contractProccessing.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine();
            Console.WriteLine("INSTALLMENTS:");
            var sumTotalInterest = 0.00;
            var sumTotalInterestInstallment = 0.00;
            var sumGrandTotal = 0.00;

            foreach (var installment in contract.Installment)
            {
                Console.WriteLine(installment);
                sumTotalInterest  += installment.TotalInterest;
                sumTotalInterestInstallment += installment.TotalInterestPerInstallment;
                sumGrandTotal += installment.GrandTotal;
            }

            Console.WriteLine();
            Console.WriteLine($"Total Interest: $ {sumTotalInterest.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.WriteLine($"Total Interest per installment: $ {sumTotalInterestInstallment.ToString("F2", CultureInfo.InvariantCulture)}");

            var sumOfTotalTnterest = sumTotalInterest + sumTotalInterestInstallment;

            Console.WriteLine();
            Console.WriteLine($"Sum of total interest: $ {sumOfTotalTnterest.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.WriteLine($"Grand Total: $ {sumGrandTotal.ToString("F2", CultureInfo.InvariantCulture)}");            

            Console.ReadLine();
        }
    }
}
