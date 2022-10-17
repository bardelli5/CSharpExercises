using System;
using System.Globalization;

namespace Udemy.Retangulo {
    internal class Retangulo {

        public double Widht;
        public double Height;

        public double Area() {
            return Widht * Height;
        }

        public double Perimeter() {
            return 2 * (Widht + Height);
        }

        public double Diagonal() {
            return Math.Sqrt((Math.Pow(Widht, 2) + (Math.Pow(Height, 2))));
        }
    }
}
