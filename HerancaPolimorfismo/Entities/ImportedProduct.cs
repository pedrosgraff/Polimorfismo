using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double acrec) : base(name, price)

        {
            customsFee = acrec;
        }

        public double totalPrice()
        {
            return customsFee + price;

        }

        public override string priceTag()
        {
            return name + "$ " + totalPrice() + " (Customs fee: $" + customsFee + ")";
        }

       
    }
}
