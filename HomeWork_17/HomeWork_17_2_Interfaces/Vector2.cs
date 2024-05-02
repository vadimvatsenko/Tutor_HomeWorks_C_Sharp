using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17_2_Interfaces
{
    public struct Vector2
    {
        public double x;
        public double y;

        public static Vector2 Up { get; } = new Vector2(0, -1);
        public static Vector2 Down { get; } = new Vector2(0, 1);
        public static Vector2 Left { get; } = new Vector2(-1, 0);
        public static Vector2 Right { get; } = new Vector2(1, 0);
        public static Vector2 Zero { get; } = new Vector2(0, 0);
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x , a.y + b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator *(Vector2 direction, double b)
        {
            return new Vector2(direction.x * b, direction.y * b);   
        }
       


    }
}
