using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    public class Events
    {
        public delegate void Collision(Shape shape, ConsoleColor color);
        public static event Collision? _colorizeShape; 

        public static void RegisterOnColorizeShape(Shape shape, ConsoleColor color) // метод, для вызова события
        {
            _colorizeShape?.Invoke(shape, color);
        }
    }
}
