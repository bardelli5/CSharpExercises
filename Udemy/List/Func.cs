using System;

namespace Udemy.List {
    internal class Func {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Func(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void increaseSalary(double porcentagem) {
            Salario = ((Salario * porcentagem / 100)) + Salario;
        }

        override public string ToString() { 
            return Id + ", " + Nome + ", R$" + Salario;
        }
    }
}
