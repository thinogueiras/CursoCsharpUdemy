using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Exercise01.Entites
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
