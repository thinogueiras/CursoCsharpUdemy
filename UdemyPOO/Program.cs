using System;
using System.Globalization;

namespace UdemyPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Produto("TV", 500.00, 10);

            p.Descricao = "T";           

            //Console.WriteLine(p.Descricao);

            Console.WriteLine(p.Descricao);

            Console.WriteLine(p.Preco);

            Console.ReadLine();
        } 
        
        static void TestarCalculadora()
        {
            //var calc = new Calculadora();

            Console.Write("Entre com o valor do raio: ");
            var raio = double.Parse(Console.ReadLine());

            var circunferencia = Calculadora.Circunferencia(raio);

            Console.WriteLine($"\nCircunferência: {circunferencia.ToString("F2")}");

            var volume = Calculadora.Volume(raio);
            Console.WriteLine($"Volume: {volume.ToString("F2")}");

            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2")}");
        }

        static void testarprodutosconsole()
        {
            var p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p);

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            var descricao = Console.ReadLine();
            Console.Write("Preço: ");
            var preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            var quantidade = int.Parse(Console.ReadLine());

            //var p = new Produto(descricao, preco);

            //var p = new Produto
            //{
            //    Descricao = "TV",
            //    Preco = 900.00,
            //    Quantidade = 40
            //};

            Console.WriteLine("\n" + "Dados do produto: " + p + "\n");

            Console.Write("Digite o número de produto a ser adicionado no estoque: ");
            int qtde = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qtde);

            Console.WriteLine("\nDados atualizados: " + p + "\n");

            Console.Write("Digite o número de produto a ser removido no estoque: ");
            qtde = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtde);

            Console.WriteLine("\nDados atualizados: " + p);

        }

        static void CalcularAreaComPOO()
        {
            var x = new Triangulo();
            var y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com as medidas do triângulo Y: ");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            var areaX = x.CalcularAreaTriangulo();
            var areaY = y.CalcularAreaTriangulo();

            Console.WriteLine("\nÁrea de x = " + areaX.ToString("F4"));
            Console.WriteLine("Área de y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior área: X");
            }
            else
                Console.WriteLine("\nMaior área: Y");
        }


        static void CalcularAreaSemPOO()
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com as medidas do triângulo Y: ");

            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            var p = (xA + xB + xC) / 2.0;
            var areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            var areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("\nÁrea de x = " + areaX.ToString("F4"));
            Console.WriteLine("Área de y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior área: X");
            }
            Console.WriteLine("\nMaior área: Y");
        }
    }
}
