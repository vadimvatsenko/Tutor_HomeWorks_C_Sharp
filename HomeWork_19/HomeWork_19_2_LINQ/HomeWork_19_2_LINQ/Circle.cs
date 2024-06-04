using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_2_LINQ
{
    internal class Circle : Shape
    {
        public static int Radius = 3;
        public double radius { get; private set; } = Radius;

        public Circle(ConsoleColor color, char symbol, Vector2 startPosition) : base(color, symbol, startPosition)
        {
        }

        /*public override void Draw()
        {
            Console.ForegroundColor = color;
            for (double angle = 0; angle < 360; angle++)
            {
                double x = startPosition.x + Math.Cos(angle) * radius;
                double y = startPosition.y + Math.Sin(angle) * radius;
                Console.SetCursorPosition((int)x, (int)y);
                Console.Write(symbol);
            }
        }*/

        // Алгоритм Брезенхема для рисования круга
        public override void Draw()
        {
            Console.ForegroundColor = color;
            double x = 0;
            double y = radius;
            double d = 3 - 2 * radius;

            DrawCirclePoints((int)startPosition.x, (int)startPosition.y, (int)x, (int)y);

            while (y >= x)
            {
                x++;

                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }
                DrawCirclePoints((int)startPosition.x, (int)startPosition.y, (int)x, (int)y);
            }
        }

        private void DrawCirclePoints(int centerX, int centerY, int x, int y)
        {
            PutPixel(centerX + x, centerY + y);
            PutPixel(centerX - x, centerY + y);
            PutPixel(centerX + x, centerY - y);
            PutPixel(centerX - x, centerY - y);
            PutPixel(centerX + y, centerY + x);
            PutPixel(centerX - y, centerY + x);
            PutPixel(centerX + y, centerY - x);
            PutPixel(centerX - y, centerY - x);
        }

        private void PutPixel(int x, int y)
        {
            if (x >= 0 && x < Console.WindowWidth && y >= 0 && y < Console.WindowHeight)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }



    }
}
