using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3.Создайте перечисление ArrayIndex с вариантами first, second, third.
// Создайте массив на 3 элемента и заполните его рандомно,
// просумируйте все элементы массива и при этом обращаться к каждому элементу нужно через enum.
// Вспомните что такое явное преобразование типов данных OK

namespace HomeWork_05_03_Enum
{
    enum ArrayIndex
    {
        first, second, third,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numb = new int[3];

            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = rnd.Next(0, 101);
            }

            foreach (int i in numb)
            {
                Console.WriteLine(i);
            }

            int summ = 0;
            
            summ = numb[(int)ArrayIndex.first] + numb[(int)ArrayIndex.second] + numb[(int)ArrayIndex.third];

            Console.WriteLine(summ);

        }
    }
}
