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
            List<Shape> shapesFill = new List<Shape>()
            {
                (new Circle(ConsoleColor.Red, new Vector2(20, 8), 5)),
                (new Rectangle(ConsoleColor.Magenta, new Vector2(40, 3), 10, 10)),
                (new Triangle(ConsoleColor.Cyan, new Vector2(65, 3), 10)),

            };

            List<Shape> shapes = new List<Shape>()
            {
                (new Circle(ConsoleColor.Red, new Vector2(20, 21), 5)),
                (new Rectangle(ConsoleColor.Magenta, new Vector2(40, 16), 10, 10)),
                (new Triangle(ConsoleColor.Cyan, new Vector2(65, 16), 10)),
            };

            foreach (Shape shape in shapesFill)
            {
                shape.FillDraw();
            }

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
           

            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}

// Shape shape1 = new Shape(ConsoleColor.Red, new Vector2(10,10)); // нельзя создавать 