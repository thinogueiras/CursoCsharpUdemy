using HerançaPolimorfismo.Exercise04.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Exercise04.Entities
{
    public class LegalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(int numberOfEmployees, string name, double annualIncome, PersonType personType) : base (name, annualIncome, personType)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalculuteTaxes()
        {
            if (NumberOfEmployees <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
