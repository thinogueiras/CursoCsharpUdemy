using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaMúltipla.Entities
{
    public class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProccessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing {document}");
        }

        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice print {document}");
        }        

        public string Scan()
        {
            return $"ComboDevice scan result";
        }
    }
}
