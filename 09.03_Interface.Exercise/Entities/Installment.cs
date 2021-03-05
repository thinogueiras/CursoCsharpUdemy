using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceExercise.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; protected set; } //Data de vencimento 
        public double Amount { get; protected set; } // quantia / valor     
        public double TotalInterest { get; protected set; }
        public double TotalInterestPerInstallment { get; protected set; }
        public double GrandTotal { get; protected set; }        

        public Installment(DateTime dueDate, double amount, double totalInterest, double totalInterestPerInstallment, double grandTotal)
        {
            DueDate = dueDate;
            Amount = amount;
            TotalInterest = totalInterest;
            TotalInterestPerInstallment = totalInterestPerInstallment;
            GrandTotal = grandTotal;
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - $ {Amount.ToString("F2", CultureInfo.InvariantCulture)}";           
        }        
    }
}
