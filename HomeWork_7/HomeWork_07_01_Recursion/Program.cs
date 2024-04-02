using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Напишіть рекурсивну функцію, яка буде повертати суму вказаної послідовності. Приклад n = 5. Результат 5 + 4 + 3 + 2 + 1 = 15 OK

namespace HomeWork_07_01_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(RecurseMethod(5));
        }

        static int RecurseMethod(int i)
        {
            if (i == 0) return 0;
            return i + RecurseMethod(i - 1);
        }
    }
}
