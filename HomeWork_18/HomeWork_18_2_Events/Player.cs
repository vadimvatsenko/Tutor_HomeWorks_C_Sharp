using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    public class Player : Shape, IMove
    {
        private double Radius;

        public Player(ConsoleColor color, double speedX, double speedY, Vector2 position, double radius) : base(color, speedX, speedY, position, 0, 0)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            for (double angle = 0; angle < 359; angle++)
            {
                Console.BackgroundColor = Color;
                double X = Position.x + Math.Cos(angle) * Radius;
                double Y = Position.y + Math.Sin(angle) * Radius;
                Console.SetCursorPosition((int)X, (int)Y);
                Console.Write(" ");
            }
        }

        public void Move(Vector2 dir)
        {
            Position += dir;
        }
    }
}
