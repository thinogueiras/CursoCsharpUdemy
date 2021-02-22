using HerançaMúltipla.Entities;
using System;

namespace HerançaMúltipla
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer() { SerialNumber = 1000 };
            printer.ProccessDoc("My letter");
            printer.Print("My letter");

            Console.WriteLine();

            var scanner = new Scanner() { SerialNumber = 1001 };
            scanner.ProccessDoc("My E-mail");
            Console.WriteLine(scanner.Scan());

            Console.WriteLine();

            var comboDevice = new ComboDevice() { SerialNumber = 1002 };
            comboDevice.ProccessDoc("My dissertation");
            comboDevice.Print("My dissertation");
            Console.WriteLine(comboDevice.Scan());

            Console.ReadLine();
        }
    }
}
