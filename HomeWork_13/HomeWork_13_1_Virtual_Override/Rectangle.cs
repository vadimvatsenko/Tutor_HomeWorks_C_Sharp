using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_1_Virtual_Override
{
    public class Rectangle : Shape
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Rectangle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override double Area()
        {
            return X * Y;
        }

        public sealed override double Perimeter()
        {
            return 2 * (X + Y);
        }

    }
}
