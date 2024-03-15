using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Для каждого x в интервале [2;8] найдите значение функции z(x,y) = xy
// Переменная y изменяется в интервале [2;5].

// Создайте два цикла for (один из них - вложенный). Переменнаяx должна изменяться во внешнем цикле, тогда как переменнаяy должна меняться во внутреннем.
// z(x, y) = 2^2 = 4 корень 2х из 2х
// z(x, y) = 2^3 = 8
// z(x, y) = 2^4 = 16
// z(x, y) = 3^2 = 9
// z(x, y) = 3^3 = 27
// z(x, y) = 3^4 = 81
// z(x, y) = 4^2 = 16
// z(x, y) = 4^3 = 64
// z(x, y) = 4^4 = 256
// z(x, y) = 5^2 = 25
// z(x, y) = 5^3 = 125
// z(x, y) = 5^4 = 625

namespace HomeWork_2_9_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 8; i++)
            {
                for(int j = 2; j <= 5; j++)
                {
                    Console.WriteLine(Math.Pow(i, j)); // 
                }
            }
        }
    }
}
