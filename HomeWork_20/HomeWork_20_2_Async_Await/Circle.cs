using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_20_2_Async_Await
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(Vector2 position, ConsoleColor color, char symbol, int radius) : base(position, color, symbol)
        {
            this.radius = radius;
        }

        async public override Task Draw()
        {
            Console.ForegroundColor = color;
            double x = 0;
            double y = radius;
            double d = 3 - 2 * radius;

            DrawCirclePoints((int)position.x, (int)position.y, (int)x, (int)y);

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
                await Task.Delay(1000);
                DrawCirclePoints((int)position.x, (int)position.y, (int)x, (int)y);
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
