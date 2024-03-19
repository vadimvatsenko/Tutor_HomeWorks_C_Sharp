using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
{
    internal class Triangle : Shape
    {
        public double Height { get; private set; }
        public Triangle(ConsoleColor color, Vector2 position, double height) : base(color, position)
        {
            Height = height;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

           

            Console.SetCursorPosition(startX, startY);

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i || i == Height - 1) 
                    {
                        Console.SetCursorPosition(startX + j, startY + i);
                        Console.WriteLine(' ');
                    }
                }
            }
        }
    

        public override void FillDraw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.SetCursorPosition(startX, startY);

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.SetCursorPosition(startX + j, startY + i);
                    Console.WriteLine(' ');
                }
            }
        }
    }
}
