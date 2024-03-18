using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
{
    internal class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(ConsoleColor color, Vector2 position, double width, double height) : base(color, position)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {

            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.SetCursorPosition(startX, startY);

            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(startX + i, startY);
                Console.WriteLine(' ');
            }

            for(int j = 0; j < Height; j++)
            {
                Console.SetCursorPosition(startX, startY + j);
                Console.WriteLine(' ');
            }

            for (int k = 0; k < Height; k++)
            {
                Console.SetCursorPosition(startX, startY + k);
                Console.WriteLine(' ');
            }
        }

        public override void FillDraw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.SetCursorPosition(startX, startY);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.SetCursorPosition(startX + j, startY + i);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
