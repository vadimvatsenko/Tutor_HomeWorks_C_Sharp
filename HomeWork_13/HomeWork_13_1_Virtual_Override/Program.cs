using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Создайте базовый класс Shape, в котором есть метод для вычисления площади фигуры Area и метод для нахождения периметра,
//оба метода должны возвращать double. Создайте 3 класса, которые будут наследоваться от класса Shape.
//Первый класс Circle, содержит поле радиус и переопределение метода Area и Perimeter. Второй класс Rectangle,
//содержит 2 поля для сторон и переопределение метода  Area и Perimeter. Третий класс Traingle содержит 3 поля и так же переопределяет метод Area и Perimeter.
//Инициализация всех объектов происходит через их конструктора. 

namespace HomeWork_13_1_Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Console.WriteLine(circle.Perimeter());
            Console.WriteLine(circle.Area());

            Shape triangle = new Traingle(10, 10, 14);
            Console.WriteLine(triangle.Perimeter());
            Console.WriteLine(triangle.Area());

            Shape rectangle = new Rectangle(10, 3);
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(rectangle.Area());

            // V2
            List<Shape> shapeList = new List<Shape>()
            {
                (new Circle(5)),
                (new Traingle(10, 10, 14)),
                (new Rectangle(10, 3)),
            };

            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape.Perimeter());
                Console.WriteLine(shape.Area());
            }
        }
    }
}
