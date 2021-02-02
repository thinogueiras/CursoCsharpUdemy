using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados
{
    class Calculator
    {
        public static int Sum(params int[] numeros)
        {
            var sum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            return sum;
        }
    }
}
