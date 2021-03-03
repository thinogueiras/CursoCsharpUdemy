using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("\nCar model: ");
            var carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            var start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            var finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            var hour = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: ");
            var day = double.Parse(Console.ReadLine());

            var carRental = new CarRental(start, finish, new Vehicle(carModel));

            var rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("\nINVOICE:");
            Console.WriteLine(carRental.Invoice);


            Console.ReadLine();
        }
    }
}
