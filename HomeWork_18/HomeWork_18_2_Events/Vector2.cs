using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    public struct Vector2
    {
        public double x; 
        public double y;

        public static Vector2 Up { get; } = new Vector2(0, -1);
        public static Vector2 Down { get; } = new Vector2 (0, 1);
        public static Vector2 Left { get; } = new Vector2 (-1, 0);
        public static Vector2 Right { get; } = new Vector2(1, 0);
        public static Vector2 Zero { get; } = new Vector2 (0, 0);

        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y - v2.y);
        }
        public static Vector2 operator *(Vector2 v1, double b)
        {
            return new Vector2(v1.x * b, v1.y * b);
        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return !(v1 == v2);
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return (v1.x == v2.x) && (v1.y == v2.y);
        }
    }
}
