using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufectureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price , DateTime data) :base (name, price)
        {
            manufectureDate= data;
        }

        public override string priceTag()
        {
            return name + "$ " + price + " (Manufacture date:" + manufectureDate.ToString("dd/MM/yyyy") + " )";
        }
    }
}
