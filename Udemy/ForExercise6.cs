using System;
using System.Globalization;
using System.Net.Mail;

namespace Udemy {
    internal class ForExercises {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
            }
            
        }
    }
}