using System;
using System.Collections.Generic;
using System.Globalization;
using Udemy.EntitiesTax;

/*namespace Udemy {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == 'i') {
                    Console.Write("Health Expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, annualIncome, healthExpenses));
                }
                else if (resposta == 'c') {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, annualIncome, employees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxesPaid in taxPayers) {
                double tax = taxesPaid.Tax();
                Console.WriteLine(taxesPaid.Name + ": $ " + tax.ToString("F2",CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}*/