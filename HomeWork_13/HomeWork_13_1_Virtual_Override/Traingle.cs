using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_1_Virtual_Override
{
    public class Traingle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Traingle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Area()
        {
            if (IsValidTriangle(A, B, C))
            {
                double s = (A + B + C) / 2;
                return Math.Sqrt(s * (s - A) * (s - B) * (s - C)); // Формула Герона
            }

            return 0;

        }

        public override double Perimeter()
        {
            return A + B + C; // периметр треугольника - это сумма всех его сторон
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a; // // Сумма длин любых двух сторон должна быть больше длины третьей стороны - проверка на валидность треугольника
        }
    }
}
