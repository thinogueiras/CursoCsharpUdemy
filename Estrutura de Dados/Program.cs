using System;
using System.Collections.Generic;
using System.Globalization;

namespace Estrutura_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>()
            {
                "Marco",
                "Thiago",
                "João"
            };

            lista.Add("Maria"); // Adiciona no final da lista
            lista.Add("Alex");
            lista.Add("Oscar");
            lista.Add("Joaquin");
            lista.Add("Ana");

            lista.Insert(2, "Gisele"); // Desloca o valor da posição 2 para a 3

            foreach (var list in lista)
            {  
                Console.WriteLine(list);
            }
            
            Console.WriteLine("\nLista count: " + lista.Count);

            Console.Write("------------------------------------------------------");

            var localizador1 = lista.Find(x => x[0] == 'A'); // Expressão que substitui a função TestLocalizador
            Console.WriteLine("\nPrimeiro item da lista que começa com A: " + localizador1);

            var localizador2 = lista.FindLast(x => x[0] == 'M');
            Console.WriteLine("\nÚltimo item da lista que começa com M: " + localizador2);
            
            Console.Write("------------------------------------------------------");

            var localizador3 = lista.FindIndex(x => x[0] == 'J');

            Console.WriteLine("\nFirst position J: " + localizador3);

            var localizador4 = lista.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("\nLast position A: " + localizador4);

            var listFiltro = lista.FindAll(x => x.Length == 5);

            foreach (var list in listFiltro)
            {
                Console.WriteLine("\n" + list + " contém " + list.Length + " caracteres");
            }

            lista.Remove(lista[5]);
            Console.Write("------------------------------------------------------" + "\n");

            foreach (var list in lista)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine("\nLista count: " + lista.Count);

            Console.Write("------------------------------------------------------" + "\n");

            lista.RemoveAll(x => x[0] == 'M');   

            foreach (var list in lista)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine("\nLista count: " + lista.Count);

            Console.Write("------------------------------------------------------" + "\n");

            lista.RemoveAt(0);
            foreach (var list in lista)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine("\nLista count: " + lista.Count);

            Console.Write("------------------------------------------------------" + "\n");

            lista.RemoveRange(1, 3);
            foreach (var list in lista)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine("\nLista count: " + lista.Count);

            Console.Write("------------------------------------------------------" + "\n");

            Console.ReadLine();
        }

        static bool TestLocalizador(string localizador)
        {
            return localizador[0] == 'A';

        }
        void TestarCalculos()
        {
            var soma1 = Calculator.SomarNumeros(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            var soma2 = Calculator.SomarNumeros(new int[] { 3, 4, 5 });

            var a = 10;
            int triplicar;

            //Calculator.TriplicarValorRef(ref a);
            Calculator.TriplicarValorOut(a, out triplicar);

            //Console.WriteLine(soma1);
            //Console.WriteLine(soma2);
            //Console.WriteLine(a);
            Console.WriteLine(triplicar);
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
