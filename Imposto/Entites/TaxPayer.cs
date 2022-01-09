using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Entites
{
    abstract   class TaxPayer
    {
        public string Name { get; set; }

        public double  Anuallncome { get; set; }

        public TaxPayer(string name, double anuallncome)
        {
            Name = name;
            Anuallncome = anuallncome;
        }

        public abstract double Tax();
        
    }
}
