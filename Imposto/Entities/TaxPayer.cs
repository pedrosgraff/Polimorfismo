using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Anuallncome { get; set; }

        public TaxPayer() { }
        protected TaxPayer(string name, double anuallncome)
        {
            this.Name = name;
            this.Anuallncome = anuallncome;
        }


        public abstract double Tax();
       

    }
}
