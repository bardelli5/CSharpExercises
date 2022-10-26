using System;
using System.Globalization;
using Udemy.ConversorDeMoeda;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine());

            double total = ConversorDeMoeda.DolarParaReal(cotacao, quantia); // = 657,20

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}