using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Entites
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anuallncome, int numberOfEmployees)
            : base(name,anuallncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double total = 0;

            if (NumberOfEmployees > 10)
            {
                total = Anuallncome * 0.14;
            }
            else
            {
                total = Anuallncome * 0.16;
            }

            return total;
        }
    }
}
