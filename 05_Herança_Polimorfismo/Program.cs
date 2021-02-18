using HerançaPolimorfismo.Exercise04.Entities;
using HerançaPolimorfismo.Exercise04.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Herança_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();

            try
            {
                Console.Write("Enter the number of tax payers: ");
                var n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"\nTax payer #{i} data:");
                    Console.Write("Individual or Company? ");
                    var personType = Enum.Parse<PersonType>(Console.ReadLine());
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    var annualIncome = double.Parse(Console.ReadLine());

                    if (personType == PersonType.Individual)
                    {
                        Console.Write("Health expenditures: ");
                        var healthExpenditures = double.Parse(Console.ReadLine());
                        list.Add(new PhysicalPerson(healthExpenditures, name, annualIncome, personType));
                    }
                    else
                    {
                        Console.Write("Number of employees: ");
                        var numberOfEmployees = int.Parse(Console.ReadLine());
                        list.Add(new LegalPerson(numberOfEmployees, name, annualIncome, personType));
                    }
                }
                Console.WriteLine();
                Console.WriteLine("TAXES PAID:");

                var sum = 0.00;
                foreach (var payers in list)
                {
                    Console.WriteLine($"{payers.Name}: $ {payers.CalculuteTaxes().ToString("F2", CultureInfo.InvariantCulture)}");
                    sum += payers.CalculuteTaxes();
                }
                Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nInvalid person type - Enter Individual or Company");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nInvalid argument - Enter as integer");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
