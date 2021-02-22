using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    public interface IPaymentService
    {
        double Interest(double amount, int months);
        double TotalInstallmentValue(double amount);
    }
}
