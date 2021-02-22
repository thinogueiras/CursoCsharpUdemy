using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaMúltipla.Entities
{
    public abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProccessDoc(string document);
    }
}
