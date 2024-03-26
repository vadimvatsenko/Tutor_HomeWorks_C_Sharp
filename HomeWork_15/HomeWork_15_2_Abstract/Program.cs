using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
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
            Console.WriteLine("Выберите фигуру: \n" +
                "1 - Triangle\n" +
                "2 - Rectangle\n" +
                "3 - Circle");
            int shape = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите цвет: \n" +
                "12 - Red\n" +
                "10 - Green\n" +
                "9 - Blue \n" +
                "14 - Yellow");
            int color = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вертикальную скорость");
            int verticalSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите горизонтальную скорость");
            int horizontalSpeed = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Shape targetShape = null;

            switch (shape)
            {
                case 1:
                    targetShape = TriangleRenderer((Color)color, horizontalSpeed, verticalSpeed); // (Color)color - привидение типов, означает, что мы передали Color.Red например
                    targetShape.FillDraw();
                    break;
                case 2:
                    targetShape = RectangleRenderer((Color)color, horizontalSpeed, verticalSpeed);
                    targetShape.FillDraw();
                    break;
                case 3:
                    targetShape = CircleRenderer((Color)color, horizontalSpeed, verticalSpeed);
                    targetShape.FillDraw();
                    break;
                default:
                    Console.WriteLine("Нет такой фигуры");
                    break;

            }

            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Введите клавишу:\n" +
                "Вверх, Вниз, Лево или Право");

            while (true)
            {
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                             
                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        targetShape.MoveDown();
                        break;
                    case ConsoleKey.UpArrow:
                        targetShape.MoveUp();
                        break;
                    case ConsoleKey.LeftArrow:
                        targetShape.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        targetShape.MoveRight();
                        break;
                    default:
                        Console.WriteLine("Неправильная клавиша");
                        continue;
                }

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        static Shape TriangleRenderer( Color color, int horizontalSpeed, int verticalSpeed)
        {
            Shape targetShape = new Triangle((ConsoleColor)color, new Vector2(55, 3), 10, horizontalSpeed, verticalSpeed);
            return targetShape;
        }

        static Shape RectangleRenderer(Color color, int horizontalSpeed, int verticalSpeed)
        {
            Shape targetShape = new Rectangle((ConsoleColor)color, new Vector2(55, 3), 10, 10, horizontalSpeed, verticalSpeed);
            return targetShape;
        }

        static Shape CircleRenderer(Color color, int horizontalSpeed, int verticalSpeed)
        {
            Shape targetShape = new Circle((ConsoleColor)color, new Vector2(55, 6), 5, horizontalSpeed, verticalSpeed);
            return targetShape;
        }
    }
}
