using System;
using System.Globalization;
using TratamentoDeExceções.Exercise.Entities;

namespace TratamentoDeExceções.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                var number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                var holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                var initialBalance = double.Parse(Console.ReadLine());
                
                Console.Write("Withdraw limit: ");
                var withdrawLimit = double.Parse(Console.ReadLine());

                Console.Write("\nEnter amount for withdraw: ");
                var withdraw = double.Parse(Console.ReadLine());

                var account = new Account(number, holder, withdrawLimit);
                account.Deposit(number, initialBalance);
                account.WithDraw(number, withdraw);

                Console.WriteLine($"\nNew balance: ${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }            
        }
    }
}
