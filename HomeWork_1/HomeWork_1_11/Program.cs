using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
// 11.	Даны целые числа a, b, c.
// Вывести значение True, если существует треугольник с соответствующими длинами сторон,
// и False в противном случае.
// Если треугольник существует, вывести его площадь.
// Указание: Вспомните «неравенство треугольника».
// Для вычисления площади воспользуйтесь формулой Герона (p означает полупериметр):
  
//Пример
//Введите три целых числа:
//4, 8, 6
//Результат: существует, его площадь 11.61895003


namespace HomeWork_1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1ю сторону");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2ю сторону");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 3ю сторону");
            double c = Convert.ToDouble(Console.ReadLine());


            if((a + b > c && a + c > b && b+ c > a) || (a <= 0 || b <= 0 || c <= 0))
            {
                Console.WriteLine("Треугольник не существует");
                return;
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine(Math.Round(area, 4));


            
        }
    }
}
