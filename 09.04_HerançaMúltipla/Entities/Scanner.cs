using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaMúltipla.Entities
{
    public class Scanner : Device, IScanner
    {
        public override void ProccessDoc(string document)
        {
            Console.WriteLine($"Scanner processing: {document}");
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
