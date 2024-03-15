using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Дан массив целых чисел (значения элементов: -1, -2, 3, 4, 5, 6, 7).
// Вычислите нечетные элементы в этом массиве, а также положительные элементы

/*Массив:
-1, -2, 3, 4, 5, 6, 7*/

    // кол - во нечетных элементов: 5, кол - во положительных 5.

namespace HomeWork_03_05_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { -1, -2, 3, 4, 5, 6, 7 };
            int incCount  = 0;
            int decCount = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 0)
                {
                    incCount++;
                } else if (num[i] < 0)
                {
                    decCount++;
                }
            }

            Console.WriteLine($"inc = {incCount}, dec = {decCount}");
        }
    }
}
