using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_2_LINQ
{
    internal class Circle : Shape
    {
        public double radius { get; private set; } = 4;

        public Circle(ConsoleColor color, char symbol, Vector2 startPosition) : base(color, symbol, startPosition)
        {
        }

        public override void Draw()
        {
            Console.ForegroundColor = color;
            for (double angle = 0; angle < 360; angle++) 
            {
                double x = startPosition.x + Math.Cos(angle) * radius;
                double y = startPosition.y + Math.Sin(angle) * radius;
                Console.SetCursorPosition((int)x, (int)y);
                Console.Write(symbol);
            }
        }

        

    }
}
