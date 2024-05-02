using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_18_2_Events
{
    public class Bullet : Shape, IShoot, IDisposable
    { 
        private bool disposed = false;

        List<Shape> Walls;
        public Bullet(ConsoleColor color, double speedX, double speedY, Vector2 position, double width, double height, List<Shape> walls) : base(color, speedX, speedY, position, width, height)
        {
            Walls = walls;
            
        }
        ~Bullet() 
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);          
            GC.SuppressFinalize(this);           
        }

        public void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                
            }
            
            disposed = true;
        }

        public override void Draw()
        {
            if(!disposed)
            {
                Console.ForegroundColor = Color;
                Console.BackgroundColor = Color;

                int startX = (int)Position.x;
                int startY = (int)Position.y;

                Console.SetCursorPosition(startX, startY);

                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height - 1; j++)
                    {
                        Console.SetCursorPosition(startX + j, startY + i);
                        Console.WriteLine(" ");
                    }
                }

                Console.SetCursorPosition(startX + (int)Width - 1, startY + (int)(Height / 2));
                Console.WriteLine(" ");
            }
            
        }

        public void Shoot(Vector2 direction, ref Player player)
        {
                
            while (true)
            {
                Shape.ResetColor();
                Console.Clear();
                Draw();

                foreach(Shape wall in Walls)
                {
                    wall.Draw();
                    if(onColission(wall)) return;
                }
                player.Draw();
                Position += direction * SpeedX;

            }                
        }

        public bool onColission(Shape wall)
        {           
            if(this == wall)
            {
                Events.RegisterOnColorizeShape(wall, Color);
                Dispose();
                return true;
            }

            return false;
        }

        

    }        
}

