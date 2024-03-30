using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
{
    internal class Circle : Shape
    {
        private double R;
        public Circle(ConsoleColor color, Vector2 position, double r, int speedX, int speedY) : base(color, position, speedX, speedY)
        {
            R = r;
        }

        public override void Draw()
        {
            for (double angle = 0; angle < 359; angle++)
            {
                Console.BackgroundColor = Color;
                double X = Position.X + Math.Cos(angle) * R;
                double Y = Position.Y + Math.Sin(angle) * R;
                Console.SetCursorPosition((int)X, (int)Y);
                Console.Write(" ");
            }
        }

        public override void FillDraw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.SetCursorPosition(startX, startY);

            double step = 1.0 / R;

            for (double i = 0; i <= Math.PI / 2; i += step)
            {
                int x = (int)Math.Round(R * Math.Cos(i));
                int y = (int)Math.Round(R * Math.Sin(i));

                
                for (int j = startY - y; j <= startY + y; j++)
                {
                    Console.SetCursorPosition(startX - x, j);
                    Console.Write(' ');
                    Console.SetCursorPosition(startX + x, j);
                    Console.Write(' ');
                }

                Console.SetCursorPosition(startX, startY + y);
                Console.Write(' ');
                Console.SetCursorPosition(startX, startY - y);
                Console.Write(' ');
            }
        }

        public override void MoveRight()
        {
            Position.X += SpeedX;
        }

        public override void MoveLeft()
        {
            Position.X -= SpeedX;
        }

        public override void MoveUp()
        {
            Position.Y -= SpeedY;
        }

        public override void MoveDown()
        {
            Position.Y += SpeedY;
        }
    }
}


