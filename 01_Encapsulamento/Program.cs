using System;
using System.Globalization;

namespace POO_Encapsulamento
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
        
        void TestarCalculadora()
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

        void testarprodutosconsole()
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

        void CalcularAreaComPOO()
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

        void CalcularAreaSemPOO()
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

        static void TestarClasseContaBancaria()
        {
            var result = true;

            while (result == true)
            {
                ContaBancaria conta;

                Console.WriteLine("Seja Bem-Vindo ao sistema bancário!!!" + "\n");

                Console.Write("Entre com o número da agência: ");
                var agencia = int.Parse(Console.ReadLine());

                Console.Write("Entre com o número da conta: ");
                var numero = int.Parse(Console.ReadLine());

                Console.Write("Informe o titular da conta: ");
                var titular = Console.ReadLine();

                Console.Write("\nHaverá depósito inicial (s/n)?: ");
                var depositoInicial = char.Parse(Console.ReadLine());

                if (depositoInicial == 's' || depositoInicial == 'S')
                {
                    Console.Write("Entre com o valor do depósito inicial: ");
                    var valorDepositoInicial = double.Parse(Console.ReadLine());
                    conta = new ContaBancaria(agencia, numero, titular, valorDepositoInicial);

                    Console.Write("\nDados da conta: " + "\n" + conta + "\n");
                }
                else
                {
                    conta = new ContaBancaria(agencia, numero, titular);
                    Console.Write("\nDados da conta: " + "\n" + conta + "\n");
                }

                Console.Write("\nEntre com um valor para depósito: ");
                var valorDepositoAdicional = double.Parse(Console.ReadLine());
                conta.Depositar(valorDepositoAdicional);
                Console.Write("\nDados da conta atualizados: " + "\n" + conta + "\n");

                Console.Write("\nEntre com o valor para saque: ");
                var valorSaque = double.Parse(Console.ReadLine());
                conta.Sacar(valorSaque);
                Console.Write("\nDados da conta atualizados: " + "\n" + conta + "\n");

                Console.Write("\nDeseja repetir a simulação (s/n)?: ");
                var repeticao = char.Parse(Console.ReadLine());

                if (repeticao == 'S' || repeticao == 's')
                {
                    result = true;
                    Console.Clear();

                }
                else
                {
                    result = false;
                }
            }
        }
    }
}
