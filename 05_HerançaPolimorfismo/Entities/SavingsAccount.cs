using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Método não pode ser sobreescrito novamente
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.00;
        }
    }
}
