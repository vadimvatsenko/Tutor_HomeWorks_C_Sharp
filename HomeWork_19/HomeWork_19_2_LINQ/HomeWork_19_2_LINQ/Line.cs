using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork_19_2_LINQ
{
    public class Line: Shape
    {
        public Vector2 endPosition {  get; private set; }
        public double speed { get; private set; } = 0.5f;
        public Line(ConsoleColor color, char symbol, Vector2 startPosition, Vector2 endPosition) : base(color, symbol, startPosition)
        {
            this.endPosition = endPosition;
        }

        public override void Draw()
        {
            Console.ForegroundColor = color;
            double x0 = startPosition.x;
            double y0 = startPosition.y;
            double x1 = endPosition.x;
            double y1 = endPosition.y;

            double dx = Math.Abs(x1 - x0);
            double dy = Math.Abs(y1 - y0);
            double sx = x0 < x1 ? 1 : -1;
            double sy = y0 < y1 ? 1 : -1;
            double err = dx - dy;

            while (true)
            {
                Console.SetCursorPosition((int)x0, (int)y0);
                
                Console.Write(symbol);

                if (x0 == x1 && y0 == y1)
                    break;

                double e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
                Thread.Sleep(25);
            }
        }

    }
}
