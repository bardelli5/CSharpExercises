using System;
using System.Globalization;
using System.Collections.Generic;
using Udemy.List;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<Func> list = new List<Func>();
            

            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Func(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int idSalarioAtualizado = int.Parse(Console.ReadLine());
            Func idResult = list.Find(x => x.Id == idSalarioAtualizado);

            if (idSalarioAtualizado != null) {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idResult.increaseSalary(porcentagem);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            foreach (Func updatedList in list) {
                Console.WriteLine("Updated list of employees:");
                Console.WriteLine(updatedList);
            }
        }
    }
}
