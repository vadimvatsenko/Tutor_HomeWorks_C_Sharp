using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Дан массив размерностью 10 рандомно заполненный числами от -10 до 10.
// Умножьте каждый элемент массива на 2 и выведите массив на экран. OK


namespace HomeWork_3_01_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { -10, -2, 0, 3, 4, 6, 8, 9, -5, -9 };

            for (int i = 0; i < numbs.Length; i++)
            {
                Console.WriteLine(numbs[i] * 2);
            }
        }
    }
}
