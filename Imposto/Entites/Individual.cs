using System;
using System.Collections.Generic;


namespace Imposto.Entites
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anuallncome, double healthExpenditures)
            : base(name,anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double total = 0;
            if (Anuallncome < 20000)
            {
                total = (Anuallncome * 0.15) - (HealthExpenditures * 0.50);
            }else
            {
                total = (Anuallncome * 0.25) - (HealthExpenditures * 0.50);
            }
            return total;
        }
    }
}
