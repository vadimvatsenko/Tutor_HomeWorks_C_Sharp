using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_3_Abstract
{
    enum ShapeType
    {
        Circle, Rectangle, Triangle,
    }

    enum Color
    {
        Red = 12, Green = 10, Blue = 9, Yellow = 14,

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете направление:\n" +
                "1 - Вниз Вверх\n" +
                "2 - Вправо Влево\n" +
                "3 - Вверх Вниз\n" +
                "4 - Влево Вправо");
            int direction = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите 1й цвет: \n" +
                "12 - Red\n" +
                "10 - Green\n" +
                "9 - Blue \n" +
                "14 - Yellow");
            int color1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите 2й цвет: \n" +
                "12 - Red\n" +
                "10 - Green\n" +
                "9 - Blue \n" +
                "14 - Yellow");
            int color2 = Convert.ToInt32(Console.ReadLine());

            

            switch (direction)
            {
                case 1:
                    Move(Vector2.Up, Vector2.Down, new Vector2(80, 10), 30, (Color)color1, (Color)color2);
                    break;
                case 2:
                    Move(Vector2.Right, Vector2.Left, new Vector2(50, 20), 15, (Color)color1, (Color)color2);
                    break;
                case 3:
                    Move(Vector2.Down, Vector2.Up, new Vector2(80, 25), 15, (Color)color1, (Color)color2);
                    break;
                case 4:
                    Move(Vector2.Left, Vector2.Right, new Vector2(50, 20), 15, (Color)color1, (Color)color2);
                    break;
            }

            Console.SetCursorPosition(0, 0);
            //Console.Clear();
            
        }

        static void Move(Vector2 dir1, Vector2 dir2, Vector2 shape, double time, Color color1, Color color2)
        {
            while (true)
            {
                Shape circle1 = new Circle((ConsoleColor)color1, shape, 5);
                double timeCounter1 = 0;
                double timeCounter2 = 0;

                while (timeCounter1 < time)
                {
                    circle1.FillDraw();
                    circle1.Move(dir1);
                    timeCounter1 += 0.1d;
                    timeCounter2 = 0;
                }
                
                Shape circle2 = new Circle((ConsoleColor)color2, new Vector2(circle1.Position.X, circle1.Position.Y), 5);
                while (timeCounter2 < time)
                {
                    circle2.FillDraw();
                    circle2.Move(dir2);
                    timeCounter2 += 0.1d;
                    timeCounter1 = 0;
                }
            }
            
                                                                
        }
    }
}
