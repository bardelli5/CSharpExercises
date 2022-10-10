using System;
using System.Globalization;
using System.Net.Mail;

namespace Udemy {
    internal class ForExercises {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int sumIn = 0;
            int sumOut = 0;

            for (int i = 1; i <= x; i++) {
                int y = int.Parse(Console.ReadLine());
                if (y >= 10 && y <= 20) {
                    sumIn++;
                }
                else {
                    sumOut++;
                }
            }

            Console.WriteLine(sumIn + " in");
            Console.WriteLine(sumOut + " out");
        }
    }
}