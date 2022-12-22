using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy.EntitiesTax {
    internal class Company : TaxPayer {

        public int Employees { get; set; }
        public Company(string name, double annualIncome, int employees) : base(name, annualIncome) {
            Employees = employees;
        }

        public override double Tax() {
            double tax = 0;
            if (Employees > 10) {
                tax = AnnualIncome * 0.14;
            }
            else {
                tax = AnnualIncome * 0.16;
            }
            return tax;
        }
    }
}
