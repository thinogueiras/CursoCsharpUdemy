using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

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
            Console.Write("\nDados da conta atualizados: " + "\n" + conta);

            Console.ReadLine();
        }
    }
}
