using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    public class ContaBancaria
    {
        public int Agencia { get; private set; }
        public int Conta { get; private set; }        
        public string Titular { get; set; }
        public double Saldo { get; private set; }        

        public ContaBancaria(int agencia, int conta, string titular)
        {
            Agencia = agencia;
            Conta = conta;            
            Titular = titular;            
        }

        public ContaBancaria(int agencia, int conta, string titular, double depositoIncial) : this(agencia, conta, titular)
        {
            Depositar(depositoIncial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Agencia {Agencia}, Conta {Conta}, Titular {Titular.ToUpper()}, Saldo : R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
