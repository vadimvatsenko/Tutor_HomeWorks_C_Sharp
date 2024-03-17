using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создать список целых чисел. Добавьте в этот список 10 рандомных чисел с помощью цикла и функции Add.
// Отсортируйте список от наименьшего к самому большому. OK

namespace HomeWork_04_03_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>(10); // почему?

            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 101));
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            list.Sort();
            Console.WriteLine("+++");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
