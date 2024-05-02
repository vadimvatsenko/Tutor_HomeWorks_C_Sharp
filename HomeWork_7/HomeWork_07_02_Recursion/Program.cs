using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Написати рекурсію, яка виводить індекс максимального числа в масиві. Функція має виглядати так
//static int MaxValue(int[] array, int index) OK

namespace HomeWork_07_02_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { -2, 6, 12, -10, 50, 40 };

            int maxIndexValue = MaxValue(numbs, 0);
            Console.WriteLine(maxIndexValue);
        }

        static int MaxValue(int[] numbs, int index)
        {
            if (index == numbs.Length - 1)
                return index;

            int maxIndex = MaxValue(numbs, index + 1);

            if (numbs[index] > numbs[maxIndex])
            {
                return index;
            } else
            {
                return maxIndex;
            }
        }
    }
}
