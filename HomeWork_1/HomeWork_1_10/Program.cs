using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.Даны три целых числа. Выведите true если, по крайней мере, два из них не равны,
// и выведите false в обратном случае. Ok

namespace HomeWork_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            Console.WriteLine(a != b && a != c && b != c);

        }
    }
}
