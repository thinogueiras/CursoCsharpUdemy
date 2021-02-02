using System;
using System.Globalization;

namespace Estrutura_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            var soma1 = Calculator.Sum(1, 2, 3);
            var soma2 = Calculator.Sum(new int[] { 3, 4, 5 });

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);

            Console.ReadLine();
        }

        void ExercicioFixacao()
        {
            Console.Write("Quantos quartos serão alugados? ");
            var n = int.Parse(Console.ReadLine());

            var vetor = new ExercicioVetorClasse[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nRenda #{i + 1}:");
                Console.Write("Nome: ");
                var nome = Console.ReadLine();
                Console.Write("Email: ");
                var email = Console.ReadLine();
                Console.Write("Quarto: ");
                var numeroQuarto = int.Parse(Console.ReadLine());

                // Alternativmente pode-se criar um construtor na classe ExercicioVetorClasse apenas com nome e email.
                vetor[numeroQuarto] = new ExercicioVetorClasse { Nome = nome, Email = email, NumeroQuarto = numeroQuarto };
            }

            Console.WriteLine("\nQuartos ocupados:");

            for (int i = 0; i < 9; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        void VetorClasse()
        {
            var n = int.Parse(Console.ReadLine());

            var vetor = new Vetor[n];

            var soma = 0.00;

            for (int i = 0; i < n; i++)
            {
                var nome = Console.ReadLine();
                var preco = double.Parse(Console.ReadLine());

                vetor[i] = new Vetor { Nome = nome, Preco = preco };
                soma += vetor[i].Preco;
            }

            var media = soma / n;

            Console.WriteLine($"\nAVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        void VetorStruct()
        {
            var n = int.Parse(Console.ReadLine());

            var vetor = new double[n];

            var soma = 0.00;

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            var media = soma / n;

            Console.WriteLine($"\nAVERAGE HEIGHT = {media.ToString("F2", CultureInfo.InvariantCulture)}");
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
