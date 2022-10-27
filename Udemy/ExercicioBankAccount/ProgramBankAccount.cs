using System.Globalization;
using System;
using Udemy;

namespace Course {
    class Program {
        static void Main(string[] args) {

            BankAccount account;
            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            char resposta = char.Parse(Console.ReadLine());

            while (resposta != 's' && resposta != 'n') {
                Console.WriteLine("resposta inválida, tente novamente: ");
                resposta = char.Parse(Console.ReadLine());
            }
            if (resposta == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(accountNumber, holder, initialDeposit);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(account);
            }
            else {
                account = new BankAccount(accountNumber, holder);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(account);
            }

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdraw);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
        }
    }
}