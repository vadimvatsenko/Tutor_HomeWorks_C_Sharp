using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Дан массив размерностью 12 рандомно заполненный числами от -20 до 20. Выведите сумму соседних элементов 
/*Пример
[12, 2, -5, 6, 7, 8]

    Вывод: 14,1,15*/

namespace HomeWork_03_02_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { -10, -2, 0, 3, 4, 6, 8, 9, -5, -9 };

            for (int i = 0; i <= numbs.Length; i++)
            {
                Console.WriteLine(numbs[i] * numbs[i + 1]);
            }
        }
    }
}
