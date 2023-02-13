using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaPolimorfismo.Entities
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }


        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string priceTag()
        {
            return name + " $ " + price.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
