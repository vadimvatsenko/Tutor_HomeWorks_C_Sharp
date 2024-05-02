using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 5.Создайте делегат для нахождения корней квадратных уравнений.
// Делегат принимает 3 числа , но ничего не возвращает.
// Добавьте так же к этому делегату еще метод, который находит площадь треугольника по формуле Герона. 

namespace HomeWork_08_05_Delegate
{
    delegate void CalcTriangle(double a,  double b, double c);
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcTriangle calc = QuadraticEquation;
            calc += AreaTriangle;

            calc(10, 5, 10);
        }

        static void QuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"У уравнения два корня: x1 = {x1}, x2 = {x2}"); ;
            }
            else if (discriminant == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"У уравнения один корень: x0 = {x0}");
            }
            else
            {
                Console.WriteLine("У уравнения нет вещественных корней.");
            }
        }

        static void AreaTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return;
            }

            // Проверяем условие треугольника            
            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2;

                // Вычисляем площадь по формуле Герона
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));


                Console.WriteLine("Площадь треугольника: " + area);

            }


        }

    }
}

