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
            int[] numbs = { -2, 6, 12, -10, 30, 40 };

            int maxValue = MaxValue(numbs, numbs.Length);
        }

        static int MaxValue(int[] numbs, int index)
        {

            int max = numbs[0];
            return 
        }
    }
}
