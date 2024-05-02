using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17_2_Interfaces
{
    
    internal class Circle : Shape, IJump, IShoot
    {
        private double R;
        public Circle(ConsoleColor color, Vector2 position, double speedX, double speedY, double r) : base(color, position, speedX, speedY)
        {
            R = r;
        }

        public override void Draw()
        {
            for (double angle = 0; angle < 359; angle++)
            {
                Console.BackgroundColor = Color;
                double X = Position.x + Math.Cos(angle) * R;
                double Y = Position.y + Math.Sin(angle) * R;
                Console.SetCursorPosition((int)X, (int)Y);
                Console.Write(" ");
            }
        }

        public void Jump(int height, double speed)
        {
            Vector2 startPosition = Position;
            int endPosition = (int)Position.y - height;

            bool isJump = false;

            while (true) 
            {
                
                if(Position.y <= endPosition)
                {
                    isJump = true;
                }

                if(Position.y >= endPosition && !isJump)
                {
                    Console.Clear();
                    position -= new Vector2(0, speed);
                    Draw();
                    Console.BackgroundColor = ConsoleColor.Black;
                    
                } 

                else if (isJump && Position.y < startPosition.y)
                {
                   Console.Clear();
                    position += new Vector2(0, speed);
                    Draw();
                    Console.BackgroundColor = ConsoleColor.Black;
                } else
                {
                    return;
                }
            
            }
        }

        public override void Move(Vector2 direction)
        {
            position += direction;
        }

        public void Shoot(Shape bullet, Vector2 direction)
        {
 
            while (true)
            {
                Console.Clear();
                
                 (bullet as Circle).position += direction; 
                bullet.Draw();
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }

        

    }
}
