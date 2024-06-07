using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
            for (double angle = 0; angle < 359; angle++)
            {
                Console.ForegroundColor = color;
                double X = position.x + Math.Cos(angle) * radius;
                double Y = position.y + Math.Sin(angle) * radius;
                Console.SetCursorPosition((int)X, (int)Y);
                //await Task.Delay(50);
                Console.Write(symbol);

                await Task.Run(() => FillDraw(X, Y));
            }
        }

        async public Task FillDraw(double x, double y)
        {
            Circle fillCircle = new Circle(new Vector2(x + 50, y), ConsoleColor.Magenta, '&', 2);

            Console.ForegroundColor = color;

            int startX = (int)fillCircle.position.x;
            int startY = (int)fillCircle.position.y;

            Console.SetCursorPosition(startX, startY);

            double step = 1.0 / fillCircle.radius;

            for (double i = 0; i <= Math.PI / 2; i += step)
            {
                int X = (int)Math.Round(fillCircle.radius * Math.Cos(i));
                int Y = (int)Math.Round(fillCircle.radius * Math.Sin(i));


                for (int j = startY - Y; j <= startY + Y; j++)
                {
                    Console.SetCursorPosition(startX - X, j);
                    Console.Write(fillCircle.symbol);
                    Console.SetCursorPosition(startX + X, j);
                    Console.Write(fillCircle.symbol);
                }

                //await Task.Delay(500);
                Console.SetCursorPosition(startX, startY + Y);
                Console.Write(fillCircle.symbol);
                Console.SetCursorPosition(startX, startY - Y);
                Console.Write(fillCircle.symbol);
            }
        }
    }
}
