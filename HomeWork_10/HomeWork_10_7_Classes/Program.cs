using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Создайте структуру Triangle. Внутри структуры создайте 4 закрытых целых полях и назвите их a b c h.
// Инициализация происходит через конструктор. Реализуйте 2 метода.
// Первый должен принимать параметр out result, в который будет записан результат, метода, метод должен находить периметр .
// Второй метод – нахождения площади, так же принимает параметр out и ничего не возвращает.
// Выведите результат на экран. Формула для площади:         S = (a · h)/2.    

namespace HomeWork_10_7_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 15, 19, 20);
            triangle.CalcPerimeter(out int perimeterResult);
            Console.WriteLine($"Perimeter: {perimeterResult}");

            triangle.Square(out int squareResult); // можно напрямую использовать squareResult и использовать ее ниже
            Console.WriteLine(squareResult);
        }
    }
}
