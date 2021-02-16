using System;
using System.Collections.Generic;
using HerançaPolimorfismo.Exercise03.Entities.Enums;
using System.Text;

namespace HerançaPolimorfismo.Exercise03.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double wight, double height, Color color) : base(color)
        {
            Width = wight;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
