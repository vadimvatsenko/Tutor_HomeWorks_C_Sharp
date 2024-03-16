using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8. Дан массив int[] numbers = { -4, -3, -2, -1,0, 1, 2, 3, 4 };.
//Переверните его в обратном порядке, для этого создайте другой массив и в него запишите элементы первого массива в обратом порядке

namespace HomeWork_03_08_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int[] b = new int[a.Length];

            for (int i = a.Length - 1; i >= 0; i--)
            {
                b[(a.Length - 1) - i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }


        }
    }
}
