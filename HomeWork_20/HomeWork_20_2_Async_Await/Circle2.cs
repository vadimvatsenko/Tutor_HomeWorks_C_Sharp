using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_20_2_Async_Await
{
    public class Circle2: Shape
    {
        public int radius { get; private set; }
        public Circle2(Vector2 position, ConsoleColor color, char symbol, int radius) : base(position, color, symbol)
        {
            this.radius = radius;
        }

        public async IAsyncEnumerable<Vector2> CircleDrawAsync()
        {

            Console.ForegroundColor = color;

            
            for (double angle = 0; angle < 360; angle += 0.5)
            {
                double X = position.x + Math.Cos(angle) * radius;
                double Y = position.y + Math.Sin(angle) * radius;
                Console.SetCursorPosition((int)X, (int)Y);
                Console.Write(symbol);
                await Task.Delay(1500);
                yield return new Vector2(X,Y);
            }

        }



        public override Task Draw()
        {
            throw new NotImplementedException();
        }

        async public Task FillDraw(double x, double y)
        {
            //Circle fillCircle = new Circle(new Vector2(x + 50, y), ConsoleColor.Magenta, '&', 2);

            Console.ForegroundColor = color;

            int startX = (int)position.x;
            int startY = (int)position.y;

            Console.SetCursorPosition(startX, startY);

            double step = 1.0 / radius;

            for (double i = 0; i <= Math.PI / 2; i += step)
            {
                int X = (int)Math.Round(radius * Math.Cos(i));
                int Y = (int)Math.Round(radius * Math.Sin(i));


                for (int j = startY - Y; j <= startY + Y; j++)
                {
                    Console.SetCursorPosition(startX - X, j);
                    Console.Write(symbol);
                    Console.SetCursorPosition(startX + X, j);
                    Console.Write(symbol);
                }

                await Task.Delay(1500);
                Console.SetCursorPosition(startX, startY + Y);
                Console.Write(symbol);
                Console.SetCursorPosition(startX, startY - Y);
                Console.Write(symbol);
            }
        }
    }
}
