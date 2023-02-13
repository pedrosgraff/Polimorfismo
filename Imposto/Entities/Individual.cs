using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anuallncome, double healthExpenditures) : base(name, anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Anuallncome <= 20000)
            {
                return (Anuallncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (Anuallncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }

    }

}


