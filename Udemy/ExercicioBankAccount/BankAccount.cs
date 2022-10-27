using System;
using System.Globalization;

namespace Udemy {
    internal class BankAccount {

        public int AccountNumber { get; private set; }  //n pode ser alterado
        public string Holder { get; set; }
        public double Balance { get; private set; } //n pode ser alterado

        public BankAccount(int accountNumber, string holder, double initialDeposit) {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance += initialDeposit;
        }

        public BankAccount(int accountNumber, string holder) {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = 0.0;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }

        override public string ToString() {
            return "Conta: " + AccountNumber + ", Titular: " + Holder + ", Saldo: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}