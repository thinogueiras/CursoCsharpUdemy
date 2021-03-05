using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TratamentoDeExceções.Exercise.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(int number, double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Incorrect value, enter a value greater than zero");
            }
            Balance += amount;
        }

        public void WithDraw(int number, double amount)
        {
            try
            {
                if (amount > WithdrawLimit)
                {
                    throw new ArgumentException("The amount exceeds withdraw limit");
                }
                else if (amount < WithdrawLimit && amount > Balance)
                {
                    throw new ArgumentException("Not enough balance");
                }
                Balance -= amount;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
