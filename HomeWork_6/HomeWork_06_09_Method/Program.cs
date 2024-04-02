using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 9. Создайте функцию, которая принимает 3 числа и вычисляет корни квадратного уравнения,
// нужно предусмотреть 3 случая, когда Дискриминант > 0, < 0 и = 0. Функция возвращать ничего  не должна

namespace HomeWork_06_09_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double x = rnd.Next(-100, 101);
            double y = rnd.Next(-100, 101);
            double z = rnd.Next(-100, 101);

            Console.WriteLine($"x = {x}, y = {y}, z = {z}");

            Method(x, y, z);
        }

        static void Method(double a, double b, double c) 
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"У уравнения два корня: x1 = {x1}, x2 = {x2}"); ;
            } else if(discriminant == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"У уравнения один корень: x0 = {x0}");
            }
            else
            {
                Console.WriteLine("У уравнения нет вещественных корней.");
            }
        }
    }
}
