using HerançaPolimorfismo.Exercise04.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Exercise04.Entities
{
    public class PhysicalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(double healthExpenses, string name, double annualIncome, PersonType personType) : base (name, annualIncome, personType)
        {
            HealthExpenses = healthExpenses;
        }

        public override double CalculuteTaxes()
        {
            if (AnnualIncome < 20000.0)
            {
                return AnnualIncome * 0.15 - HealthExpenses * 0.50;                
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenses * 0.50;
            }
        }
    }
}
