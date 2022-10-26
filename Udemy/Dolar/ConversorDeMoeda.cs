using System;

namespace Udemy.ConversorDeMoeda {
    internal class ConversorDeMoeda {

        public static double Iof = 0.06;

        public static double DolarParaReal(double cotacao, double quantia) {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
