using System;
using System.Collections.Generic;
using HerançaPolimorfismo.Exercise03.Entities.Enums;
using System.Text;

namespace HerançaPolimorfismo.Exercise03.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radaius, Color color) : base(color)
        {
            Radius = radaius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
