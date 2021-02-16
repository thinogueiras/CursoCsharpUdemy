using System;
using System.Collections.Generic;
using HerançaPolimorfismo.Exercise03.Entities.Enums;
using System.Text;

namespace HerançaPolimorfismo.Exercise03.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
