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

            Console.ReadLine();
        }

        static void TestEnum ()
        {
            var order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            var txt = OrderStatus.PendingPayment.ToString(); // Coversão de enum para string

            var os = Enum.Parse<OrderStatus>("Delivered"); // Conversão de string para Enum

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
