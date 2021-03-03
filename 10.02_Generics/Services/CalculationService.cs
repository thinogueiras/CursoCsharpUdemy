using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Services
{
    public class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) // Maior que zero indica que o objeto list[i] é maior que o max
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
