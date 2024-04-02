using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2.Вводятся три числа — длины трех сторон треугольника.
// Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
// Параметры  передаются с модификатором in.
// Функция должна возвращать результат

namespace HomeWork_06_02_Method
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine(Perimeter(a, b, c));
        }

        static double Perimeter(in double a, in double b, in double c )
        {
            return a + b + c;
        }
    }
}
