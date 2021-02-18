using HerançaPolimorfismo.Exercise04.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismo.Exercise04.Entities
{
    public abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public PersonType PersonType { get; set; }
        public double Taxes { get;  set; }

        public Person(string name, double annualIncome, PersonType personType)
        {
            Name = name;
            AnnualIncome = annualIncome;
            PersonType = personType;
        }        

        public abstract double CalculuteTaxes();        
    }
}
