using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyPOO
{
    public class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double _raio)
        {
            return 2.0 * Pi * _raio;
        }

        public static double Volume(double _raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(_raio, 3);
        }
    }    
}
