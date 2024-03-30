using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7. Создайте список и заполните его 10 рандомными числами.
// Создайте массив на 6 чисел.
// Скопируйте в массив 3 числа из списка, при этом индекс у списка начинается с 4 элемента,
// а индекс у массива начинается со второго элемента.ОК

namespace HomeWork_04_07_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 10, 17, 30, 66, 11, 8, 6, 3, 1, 50 };
            int[] numbs = new int[6];

             list.CopyTo(4, numbs, 0, 6); // 4 - индекс в списке, numbs - массив в который копируем, 0 - индекс массива с которого начинаем заливку, 6 - количество чисел копирования

            foreach (int num in numbs)
            {
                Console.WriteLine(num);
            }


        }
    }
}
