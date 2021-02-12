using EnumeraçõesComposições.CourseExercise02.Entities;
using EnumeraçõesComposições.CourseExercise02.Entities.Enums;
using EnumeraçõesComposições.CourseExercise01.Entities;
using EnumeraçõesComposições.CourseExercise01.Entities.Enums;
using EnumeraçõesComposições.Entities;
using EnumeraçõesComposições.Entities.Enums;
using System;
using System.Globalization;

namespace Enumerações_Composições
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            var clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            var email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            var birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            var status = Enum.Parse<OrderStatus>(Console.ReadLine());

            var client = new Client(clientName, email, birthDate);
            var order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? : ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                var productName = Console.ReadLine();
                Console.Write("Product price: ");
                var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var product = new Product(productName, price);

                Console.Write("Quantity: ");
                var quantity = int.Parse(Console.ReadLine());

                var orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            Console.ReadLine();
        }

        void EscopeExercise01()
        {
            Console.Write("Digite o nome do departamento: ");
            var departamento = Console.ReadLine();

            Console.WriteLine("\nInforme os dados do trabalhador: ");
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a senioridade do trabalhador: ");
            var level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Digite o salário fixo do funcionário: ");
            var salarioFixo = double.Parse(Console.ReadLine());

            var department = new Department(departamento);
            var worker = new Worker(nome, level, salarioFixo, department);

            Console.Write("\nAdicionar quantos contratos para o funcionário? ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"\nInforme a #{i} data do contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                var data = DateTime.Parse(Console.ReadLine());

                Console.Write("\nValor por hora do funcionário: ");
                var valorPorHora = double.Parse(Console.ReadLine());

                Console.Write("\nDigite a quantidade de horas do contrato: ");
                var horas = int.Parse(Console.ReadLine());

                var contract = new HourContract(data, valorPorHora, horas);

                worker.AddContracts(contract);
            }

            Console.Write("\nEntre com o mês e ano para calcular o ganho (MM/YYYY): ");
            var anoMes = Console.ReadLine();
            var mes = int.Parse(anoMes.Substring(0, 2));
            var ano = int.Parse(anoMes.Substring(3));

            Console.WriteLine("\nResumo: ");
            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            Console.WriteLine($"Ganho no período {anoMes} R$ {worker.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        void TestEnum()
        {
            var orderTest = new OrderTest
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatusTest.PendingPayment
            };

            Console.WriteLine(orderTest);

            var txt = OrderStatusTest.PendingPayment.ToString(); // Coversão de enum para string

            var os = Enum.Parse<OrderStatusTest>("Delivered"); // Conversão de string para Enum

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
