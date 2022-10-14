using System;
using System.Globalization;
using Udemy.Funcionario;

namespace Course {
    class Program {
        static void Main(string[] args) {
            
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double salaryAvg = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Salario Medio: " + salaryAvg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}