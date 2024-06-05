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

        async public override void Draw()
        {
            for (double angle = 0; angle < 359; angle++)
            {
                Console.ForegroundColor = color;
                double X = position.x + Math.Cos(angle) * radius;
                double Y = position.y + Math.Sin(angle) * radius;
                await Task.Delay(1500);
                Console.SetCursorPosition((int)X, (int)Y);
                Console.Write(symbol);
            }
        }
    }
}
