using System;
using System.Globalization;
using System.Net.Mail;

namespace Udemy {
    internal class ForExercises {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            double media;

            for (int i = 0; i < x; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0]);
                double b = double.Parse(valores[1]);
                double c = double.Parse(valores[2]);

                media = (((a * 2) + (c * 3) + (c * 5)) / 10);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}