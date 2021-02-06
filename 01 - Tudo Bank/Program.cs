using System;

namespace Tudo_Bank
{
    class Program
    {
        static void Main(string[] args)
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
