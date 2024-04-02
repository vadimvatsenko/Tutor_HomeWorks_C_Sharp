using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6.Создайте метод Distance который вычисляет расстояние между двумя точками на плоскости.
// Координаты точек вводятся (переменные x1, y1 — для первой точки, и x2, y2 — для второй).
// Метод выводит ответ на экран. 
// Для подсчета расстояния между двумя точками на плоскости используйте формулу:
	


namespace HomeWork_06_06_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 1.0;
            double x2 = 2.0;
            double y1 = 4.0;
            double y2 = 6.0;

            Distance(x1,x2,y1,y2);
        }

        static void Distance(double a1, double a2, double b1, double b2)
        {
            double distance = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine(distance);
        }
    }
}
