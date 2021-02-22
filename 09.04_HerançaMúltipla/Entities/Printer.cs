using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaMúltipla.Entities
{
    public class Printer : Device, IPrinter
    {
        public override void ProccessDoc(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }

        public void Print(string document)
        {
            Console.WriteLine($"Printer print {document}");
        }
    }
}
