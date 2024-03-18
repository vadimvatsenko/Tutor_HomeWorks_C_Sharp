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
            List<int> numb1 = new List<int>(6);
            List<int> numb2 = new List<int>(numb1.Count);

            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                numb1.Add(rnd.Next(0, 101));
            }

            foreach (int i in numb1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("+++");

/*            numb2.InsertRange(3, )*/
        }
    }
}
