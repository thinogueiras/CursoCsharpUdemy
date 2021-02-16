using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Entities
{
    public abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
