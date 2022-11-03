using System;
using Udemy.Pensionato;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Pensionato[] rooms = new Pensionato[10];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                rooms[quarto] = new Pensionato(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados:");
            for (int i = 0; i < rooms.Length; i++) {
                if (rooms[i] != null) {
                    Console.WriteLine(i + ": " + rooms[i]);
                }
            }
        }
    }
}