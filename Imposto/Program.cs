using System;
using Imposto.Entites;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            for ( int i =1; i <= n; i++)
            {

                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Anual income:");
                double anuallncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'i'|| resp =='I')
                {
                    Console.Write("Health expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anuallncome, healthExpenditures));


                }else if(resp == 'c'|| resp == 'C')
                {
                    Console.Write("Number of employees:");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anuallncome, numberOfEmployees));


                }

            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
           foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine(taxPayer.Name + " :  $" + taxPayer.Tax().ToString("F2",CultureInfo.InvariantCulture));

                sum += tax;
            }
            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ "+ sum.ToString(CultureInfo.InvariantCulture));
        }
    }
}
