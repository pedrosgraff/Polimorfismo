
using System;
using System.Collections.Generic;
using System.Globalization;
using Imposto.Entities;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of tax payers: ");
            int qtd = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new();
            double tot = 0;

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c) ? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double gain = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double loss = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, gain, loss));
                }
                else
                {
                    Console.Write("Number of employees");
                    int qtdE = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, gain, qtdE));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
                tot += tax.Tax();

            }
            Console.WriteLine("TOTAL TAXAS " + tot);
        }
    }
}