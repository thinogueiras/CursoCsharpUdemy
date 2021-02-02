using System;

namespace Estrutura_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        void TestarNullable()
        {
            double? x = null;
            double? y = 10;

            // Atribui a variável a o valor de x, mas se x for null, então atribui o valor 5.
            double a = x ?? 5;
            // Atribui a variável b o valor de y, mas se x for null, então atribui o valor 10.
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
