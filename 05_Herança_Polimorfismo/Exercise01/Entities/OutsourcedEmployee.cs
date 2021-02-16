using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Exercise01.Entites
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
