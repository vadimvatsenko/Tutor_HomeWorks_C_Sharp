using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Создайте метод GetPow(), который принимает два целочисленных аргумента — число и степень.
// Метод возвращает результат возведения числа в степень. 

namespace HomeWork_06_03_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = 5; // степень
            double numb = 8;

            Console.WriteLine(GetPow(degree, numb));
        }

        static double GetPow(in double deg, in double n)
        {
            return Math.Pow(n, deg);
        }
    }
}
