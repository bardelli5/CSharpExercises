using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy.EntitiesTax {
    internal class Individual : TaxPayer {
        public double HealthExpenses { get; set; }

        public Individual(string name, double annualIncome, double healthExpenses) : base(name, annualIncome) {
            HealthExpenses = healthExpenses;
        }

        public override double Tax() {
            double tax = 0;
            if (AnnualIncome < 20000.00) {
                tax = (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
            }
            else {
                tax = (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
            }
            return tax;
        }
    }
}
