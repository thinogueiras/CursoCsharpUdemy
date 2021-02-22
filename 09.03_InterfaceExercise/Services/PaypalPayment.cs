using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    public class PaypalPayment : IPaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double TotalInstallmentValue(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
