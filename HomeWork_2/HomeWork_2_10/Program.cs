using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Для каждого x в интервале [30;33] найдите значение функции z(x,y) = x - y.
// Переменная y изменяется в интервале [1;5].
// Указание: Создайте два цикла for (один из них - вложенный).
// Переменная x должна изменяться во внешнем цикле, тогда как переменная y должна меняться во внутреннем

namespace HomeWork_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 30; i <= 33; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.WriteLine(i - j);
                }
            }
        }
    }
}
