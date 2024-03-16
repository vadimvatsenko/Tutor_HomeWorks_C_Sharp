using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Создать список целых чисел. Добавьте в этот список 10 рандомных чисел с помощью цикла и функции Add.
//Выведите максимальный и минимальный элемент списка и их индексы OK

namespace HomeWork_04_01_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<int> numb = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numb.Add(rnd.Next(1, 20));
            }

            int MinValue = 0;
            int MaxValue = 0;

            for (int i = 0; i < numb.Count; i++)
            {
                
            }
        }
    }
}
