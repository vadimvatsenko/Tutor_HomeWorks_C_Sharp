using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Выведите в консоль последовательность чисел -3 0 3 6 9 12 15 18 21 24.
// Выполните задание, используя цикл FOR.
// Изменение счетчика должно соответствовать увеличению его на 3.
namespace HomeWork_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = -3; i <= 24; i+=3) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}
