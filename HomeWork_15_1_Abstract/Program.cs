using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                /*(new Circle(ConsoleColor.Red, new Vector2(20, 3),6)),*/
                //(new Rectangle(ConsoleColor.Magenta, new Vector2(10, 3), 10, 10)),
                (new Rectangle(ConsoleColor.Magenta, new Vector2(25, 3), 10, 10)),
            };

            foreach (Shape shape in shapes)
            {
/*                shape.FillDraw();*/
                shape.Draw();
            }

            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
