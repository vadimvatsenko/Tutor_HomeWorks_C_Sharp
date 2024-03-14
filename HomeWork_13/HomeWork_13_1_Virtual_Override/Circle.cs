using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_1_Virtual_Override
{
    public class Circle : Shape
    {
        public double R { get; private set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(R, 2); // площадь круга - формула
        }



        public override double Perimeter()
        {
            return 2 * Math.PI * R;
        }
    }
}
