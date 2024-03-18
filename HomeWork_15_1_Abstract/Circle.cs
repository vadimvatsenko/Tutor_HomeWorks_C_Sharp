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
        public Circle(ConsoleColor color, Vector2 position, double r) : base(color, position)
        {
            R = r;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.X;

            Console.SetCursorPosition(startX, startY);



        }

        public override void FillDraw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            for (int y = -(int)R; y <= R; y++)
            {
                for (int x = -(int)R; x <= R; x++)
                {
                    double distance = Math.Sqrt(x * x + y * y);

                    if (distance <= R)
                    {
                        Console.SetCursorPosition(startX + x, startY + y);
                        Console.Write("1");

                    }
                }
                    Console.WriteLine();
            }
        }
    }
}

