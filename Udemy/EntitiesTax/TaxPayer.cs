using System;
using System.Collections.Generic;

namespace Udemy.EntitiesTax {
    abstract class TaxPayer {
        public string Name { get; protected set; }
        public double AnnualIncome { get; protected set; }

        protected TaxPayer(string name, double annualIncome) {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
