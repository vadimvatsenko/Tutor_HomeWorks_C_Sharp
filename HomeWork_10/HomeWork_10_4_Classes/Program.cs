using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создать класс с названием Component. Создать в нем 3 вещественных поля x, y, z.
// Создать 3 перегруженных конструктора с одним параметром, двумя и тремя параметрами,
// которые будут вызываться по цепочке и инициализировать поля.
// Создайте метод, который будет находить абсолютную величину данного объекта с использованием 3 полей.
// В мейне вызовите 3 конструктора и покажите абсолютную величину каждого объекта.

namespace HomeWork_10_4_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Components components1 = new Components();

            Console.WriteLine(components1.GetAbsoluteValue());

            Components components2 = new Components(10.6);
            Console.WriteLine(components2.GetAbsoluteValue());

            Components components3 = new Components(20.3, 70);
            Console.WriteLine(components3.GetAbsoluteValue());

            Components components4 = new Components(30.1, 40.6, 55);
            Console.WriteLine(components4.GetAbsoluteValue());
        }
    }
}
