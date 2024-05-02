using System;
using static HomeWork_18_2_Events.Events;

namespace HomeWork_18_2_Events 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 50);

            Player player = new Player(ConsoleColor.Red, 1, 1, new Vector2(10, 7), 5);
                                    
            List<Shape> wall = new List<Shape>()
            {
                new Wall(ConsoleColor.White, 1, 1, new Vector2(70, 2), 2, 10),
                new Wall(ConsoleColor.White, 1, 1, new Vector2(70, 12), 2, 10),
                new Wall(ConsoleColor.White, 1, 1, new Vector2(70, 22), 2, 10),
                new Wall(ConsoleColor.White, 1, 1, new Vector2(70, 32), 2, 10),
            };

            player.Draw();

            foreach (Wall shape in wall)
            {
                shape.Draw();
            }

            while (true)
            {
                //Bullet bullet = null;
                Console.SetCursorPosition(0, 0);
                player.Draw();
                foreach (Wall shape in wall)
                {
                    shape.Draw();
                }
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        player.Move(Vector2.Up); 
                        break;
                    case ConsoleKey.DownArrow:
                        player.Move(Vector2.Down);
                        break;
                    case ConsoleKey.LeftArrow:
                        player.Move(Vector2.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        player.Move(Vector2.Right);
                        break;
                    case ConsoleKey.G:
                        
                        Bullet bullet = new Bullet(ConsoleColorRandomazer.GetRandomColor(), 5, 1, new Vector2(player.Position.x + 6, player.Position.y - 1), 3, 3, wall);
                        bullet.Shoot(Vector2.Right, ref player);                        
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        continue;
                }

                Console.SetCursorPosition(0, 0);
                Shape.ResetColor();
                Console.Clear();                
            }
        }
    }
}
