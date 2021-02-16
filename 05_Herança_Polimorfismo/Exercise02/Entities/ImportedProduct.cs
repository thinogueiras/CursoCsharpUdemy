using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerançaPolimorfismo.Exercise02.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct(double customsFree, string name, double price) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Customs Free: $ {CustomsFree.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
