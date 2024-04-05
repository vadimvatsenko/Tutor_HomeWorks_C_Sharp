using System;

// Создайте интерфейсы IShoot и IJump.
// Внутри интерфейса IShoot создайте метод с названием Shoot(Shape bullet, Vector2 direction),
// а внутри IJump – метод с названием Jump(int height,double speed).
// Circle Должен реализовывать эти 2 интерфейса.
// Стрельба и прыжок реализовывается только внутри класса Circle
// и нигде больше, в мейне происходит только проверка на нажатие клавиш и вызов соответствующих методов
// В структуре сделайте перегрузку оператора * для умножения вектора на double.
// Также создайте статическое свойство с названием  zero, которое должно возвращать нулевой вектор

namespace HomeWork_17_2_Interfaces 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(ConsoleColor.Red, new Vector2(10,20),0.5, 0.5 , 5);
            circle.Draw();

            Console.SetCursorPosition(0,0);

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        circle.MoveDown();
                        break;
                    case ConsoleKey.UpArrow:
                        circle.MoveUp();
                        break;
                    case ConsoleKey.LeftArrow:
                        circle.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        circle.MoveRight();
                        break;
                    case ConsoleKey.Spacebar:
                        circle.Jump(10, 0.5);
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine("Shoot");
                        break;
                    default:
                        Console.WriteLine("Неправильная клавиша");
                        continue;
                }

                Console.Clear();
                circle.Draw();
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }
    }
}
