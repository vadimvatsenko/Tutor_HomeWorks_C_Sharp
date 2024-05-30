using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_2_LINQ
{
    public struct Vector2
    {
        public double x {  get; private set; }
        public double y {  get; private set; }

        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator +(Vector2 a, double b)
        {
            return new Vector2(a.x + b, a.y + b);
        }

        public static Vector2 operator *(Vector2 direction, double b)
        {
            return new Vector2(direction.x * b, direction.y * b);
        }

        public static bool operator ==(Vector2 a, Vector2 b) 
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return !(a == b);
        }


        public static double Distance(Vector2 a, Vector2 b)
        {
            Vector2 result = a - b;
            return Math.Sqrt(result.x * result.x + result.y * result.y);
        }
    }
}
