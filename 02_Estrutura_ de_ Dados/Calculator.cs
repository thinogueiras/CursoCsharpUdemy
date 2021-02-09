using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados
{
    class Calculator
    {
        public static int SomarNumeros(params int[] numeros)
        {
            var sum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            return sum;
        }

        public static void TriplicarValorRef(ref int x)
        {
            x *= 3;
        }

        public static void TriplicarValorOut(int origem, out int result)
        {
            result = origem * 3;
        }
    }
}
