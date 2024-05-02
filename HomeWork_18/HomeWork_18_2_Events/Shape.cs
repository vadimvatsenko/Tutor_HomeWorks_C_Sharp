using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    public abstract class Shape
    {
        public ConsoleColor Color { get; protected set; }

        private protected double SpeedX;
        private protected double SpeedY;
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public Vector2 Position { get; protected set; }
        public Shape(ConsoleColor color, double speedX, double speedY, Vector2 position, double width, double height)
        {
            Color = color;
            SpeedX = speedX;
            SpeedY = speedY;
            Position = position;
            Width = width;
            Height = height;
        }
        public abstract void Draw();
        public static void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static bool operator ==(Shape left, Shape right)
        {
            int rightX1 = (int)right.Position.x;
            int rightX2 = rightX1 + (int)right.Width;

            int rightY1 = (int)right.Position.y;
            int rightY2 = rightY1 + (int)right.Height;

            int leftX1 = (int)left.Position.x;
            int leftX2 = leftX1 + (int)left.Width + 2;

            int leftY1 = (int)left.Position.y;
            int leftY2 = leftY1 + (int)left.Height;


            bool xColl = rightX1 < leftX2 && rightX2 > leftX1;
            bool yColl = rightY1 < leftY2 && rightY2 > leftY1;

            return xColl && yColl;
        }

        public static bool operator !=(Shape left, Shape right)
        {
            return !(left == right);
        }

        public static bool operator >(Shape left, Shape right)
        {
            int rightX1 = (int)right.Position.x;
            int rightX2 = rightX1 + (int)right.Width;

            int rightY1 = (int)right.Position.y;
            int rightY2 = rightY1 + (int)right.Height;

            int leftX1 = (int)left.Position.x;
            int leftX2 = leftX1 + (int)left.Width + 2;

            int leftY1 = (int)left.Position.y;
            int leftY2 = leftY1 + (int)left.Height;

            bool xColl = rightX1 > leftX2 && rightX2 > leftX1;
            bool yColl = rightY1 > leftY2 && rightY2 > leftY1;

            return xColl && yColl;
        }

        public static bool operator <(Shape left, Shape right)
        {
            return false;
        }
    }
}
