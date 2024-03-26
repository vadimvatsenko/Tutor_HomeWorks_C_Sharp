using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
{
   public class Rectangle : Shape
   {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(ConsoleColor color, Vector2 position, double width, double height, int speedX, int speedY) : base(color, position, speedX, speedY)
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

            for (int i = 0; i < Width; i++) // верхняя полоска
            {
                Console.SetCursorPosition(startX + i, startY);
                Console.WriteLine(' ');
            }

            for (int j = 0; j < Height; j++) // левая полоска
            {
                Console.SetCursorPosition(startX, startY + j);
                Console.WriteLine(' ');
            }

            for (int k = 0; k < Height; k++) // правая полоска
            {
                Console.SetCursorPosition(startX + (int)Width - 1, startY + k);
                Console.WriteLine(' ');
            }

            for (int l = 0; l < Width; l++) // нижняя полоска
            {
                Console.SetCursorPosition(startX + l, startY + (int)Height - 1);
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

        public override void MoveRight()
        {
            Console.Clear();
            Position.X += SpeedX;
            FillDraw();
        }

        public override void MoveLeft()
        {
            Console.Clear();
            Position.X -= SpeedX;
            FillDraw();
        }

        public override void MoveUp()
        {
            Console.Clear();
            Position.Y -= SpeedY;
            FillDraw();
        }

        public override void MoveDown()
        {
            Console.Clear();
            Position.Y += SpeedY;
            FillDraw();
        }
    }
}
