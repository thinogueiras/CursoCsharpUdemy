using InterfaceExercise.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise.Services
{
    public class ContractProcessing
    {
        private IPaymentService _paymentService;

        public ContractProcessing(IPaymentService paymentService)
        { 
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            var amountContract = contract.TotalValue / months;
            var totalInterest = 0.00;
            var totalInterestPerInstallment = 0.00;
            var grandTtotal = 0.00;

            for (int i = 1; i <= months; i++)
            {
                var contractDate = contract.Date.AddMonths(i);

                totalInterest = _paymentService.Interest(amountContract, i) / i;
                
                var installmentWithMonthlyInterest = amountContract + _paymentService.Interest(amountContract, i);

                totalInterestPerInstallment = installmentWithMonthlyInterest + _paymentService.TotalInstallmentValue(installmentWithMonthlyInterest) - installmentWithMonthlyInterest + totalInterest;

                var totalValueInstallment = installmentWithMonthlyInterest + _paymentService.TotalInstallmentValue(installmentWithMonthlyInterest);

                grandTtotal = totalValueInstallment;

                contract.AddInstallment(new Installment(contractDate, totalValueInstallment, totalInterest, totalInterestPerInstallment, grandTtotal));
            }            
        }
    }
}
