using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7. Дан массив 10 элементов случайно сгенерированными числами диапазона от -5 до 50.
// Посчитайте сколько элементов в этом массиве, которые кратны 3

/*Пример
Массив: 
1, 2, 3, 4, 5, 6, 7, 12, 9, 10
элементы кратные 3: 
3  6  12  9
кол - во элементов кратных 3: 4*/

namespace HomeWork_03_07_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] numb = new int[10];

            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = rnd.Next(-5, 51);
            }

            int countNumb = 0;

            for (int i = 0;i < numb.Length; i++)
            {
                if(numb[i] % 3 == 0)
                {
                    Console.WriteLine(numb[i]);
                    countNumb++;
                }
            }

            Console.WriteLine(countNumb);
        }
    }
}
