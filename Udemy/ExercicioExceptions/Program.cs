using System.Collections.Generic;
using System.Globalization;
using System;
using Udemy.ExercicioExceptions.Exceptions;
using Udemy.ExercicioExceptions;

namespace Udemy
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                Console.WriteLine("Enter Account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine("New Balance: $" + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
                }
            catch (DomainExceptions e)
                {
                Console.WriteLine("Withdraw error: " + e.Message);
                }
            catch (FormatException e)
                {
                Console.WriteLine("Error!" + e.Message);
                }
            }
        }
    }