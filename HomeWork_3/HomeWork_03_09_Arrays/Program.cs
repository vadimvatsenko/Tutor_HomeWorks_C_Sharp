using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 9. Дан массив вещественных чисел (значения элементов: 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1)
// Найдите минимальный и максимальный элемент массива. При этом использовать стандартные min и max функции запрещено.

namespace HomeWork_03_09_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numb = { 1.1, -2.3, 3.7, 4.1, 5.6, 6.1, 7.1 };

            double maxValue = numb[0];
            double minValue = numb[0];

            for (int i = 0; i < numb.Length; i++)
            {
                if (maxValue < numb[i])
                {
                    maxValue = numb[i];

                } else if (minValue > numb[i]) 
                { 
                    minValue = numb[i];
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
        }
    }
}
