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
                    TriangleRenderer((Color)color, horizontalSpeed, verticalSpeed); // (Color)color - привидение типов, означает, что мы передали Color.Red например

                    break;
                case 2:
                    RectangleRenderer((Color)color, horizontalSpeed, verticalSpeed);
                    break;
                case 3:
                    CircleRenderer((Color)color, horizontalSpeed, verticalSpeed);
                    break;
                default:
                    Console.WriteLine("Нет такой фигуры");
                    break;

            }

            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Введите клавишу:\n" +
                "Вверх, Вниз, Лево или Право");



            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;
        }


        static void TriangleRenderer(Color color, int horizontalSpeed, int verticalSpeed)
        {
            Shape targetShape = new Triangle((ConsoleColor)color, new Vector2(55, 3), 10, horizontalSpeed, verticalSpeed);
            targetShape.FillDraw();
            InputHandler(targetShape);
          
        }

        static void RectangleRenderer(Color color, int horizontalSpeed, int verticalSpeed)
        {
            Shape targetShape = new Rectangle((ConsoleColor)color, new Vector2(55, 3), 10, 10, horizontalSpeed, verticalSpeed);
            targetShape.FillDraw();
            InputHandler(targetShape);
        }

        static void CircleRenderer(Color color, int horizontalSpeed, int verticalSpeed)
        {
            Shape targetShape = new Circle((ConsoleColor)color, new Vector2(55, 6), 5, horizontalSpeed, verticalSpeed);
            targetShape.FillDraw();
            InputHandler(targetShape);
        }

        static ConsoleKeyInfo InputHandler(Shape targetShape)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
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

                Console.Clear();
                targetShape.FillDraw();
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }

    

    // дописать//
}

