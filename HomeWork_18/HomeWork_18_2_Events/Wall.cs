using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    public class Wall : Shape, IChangeColor
    {
        public Wall(ConsoleColor color, double speedX, double speedY, Vector2 position, double width, double height) : base(color, speedX, speedY, position, width, height)
        {
            Events._colorizeShape += ChangeColor; // подписка
        }

        ~Wall() 
        { 
            Events._colorizeShape -= ChangeColor;
        }

        public void ChangeColor(Shape shape, ConsoleColor color)
        {
            (shape as Wall).Color = color; // привидение типов у классов (is разобрать)
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.x;
            int startY = (int)Position.y;

            Console.SetCursorPosition(startX, startY);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.SetCursorPosition(startX + i, startY + j);
                    Console.WriteLine(' ');
                }
            }
        }
       
    }
}
