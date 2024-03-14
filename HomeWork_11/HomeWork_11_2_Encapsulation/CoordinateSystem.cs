using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_2_Encapsulation
{
    internal class CoordinateSystem
    {
        public enum TypeSystem
        {
            Polar,
            Decart
        }

        private double x, y, alpha, r; // x - координата x, // y - координата y // r - радиус полярный, // alpha - полярный угол
        public CoordinateSystem(double v, double v2, TypeSystem typeSystem)
        {
            switch (typeSystem)
            {
                case TypeSystem.Decart:
                    X = v;
                    Y = v2;
                    break;
                case TypeSystem.Polar:
                    /*R = Math.Round(Math.Sqrt(v * v + v2 * v2), 2); // корень X(в квадрате) + Y(в квадрате) 
                    Alpha = Math.Round(Math.Atan2(v2, v), 2); // вычисление угла*/
                    R = v;
                    Alpha = v2;
                    break;
                default: throw new ArgumentException("Wrong TypeSystem");
            }
        }

        public double X
        {
            get { return x; }
            private set { x = value; }
        }

        public double Y
        {
            get { return y; }
            private set { y = value; }
        }

        public double Alpha
        {
            get { return alpha; }
            private set
            {
                if (value >= 0 && value <= 360)
                {
                    alpha = value;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        public double R
        {
            get { return r; }
            private set { r = value; }
        }

        public void ConvertFromPolarToDecard()
        {
            X = R * Math.Cos(Alpha); // радиус на косинус Alpha
            Y = R * Math.Sin(Alpha); // радиус на синус Alpha
        }

        public void ConvertFromDecardToPolar()
        {
            Alpha = Math.Atan2(Y, X);
            R = Math.Sqrt(X * X + Y * Y);
        }

        public void FromDegreeToRadian() // угол в радианах
        {
            Alpha = Alpha * (Math.PI / 180.0);
        }

        public void FromRadianToDegree() // угол в градусах
        {
            Alpha = Alpha * (180.0 / Math.PI);
        }

        public void PrintData(TypeSystem typeSystem)
        {
            switch (typeSystem)
            {
                case TypeSystem.Polar:
                    Console.WriteLine($"Полярные координаты: (r = {R}, alpha = {alpha} ");
                    break;
                case TypeSystem.Decart:
                    Console.WriteLine($"Декартовые координаты: (x = {X}, y = {Y})");
                    break;
                default:
                    throw new ArgumentException("Wrong TypeSystem");

            }

        }
    }
}
