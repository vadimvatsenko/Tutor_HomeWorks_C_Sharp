using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Выведите в консоль следующую последовательность:
// 1 2 3 4 . . . 99 100 99 . . . 3 2 1.  
// Указание 1: Создайте два цикла for:
// один - для последовательности 1 2 3 4 . . . 99 100 и
// второй - для последовательности 99 . . . 3 2 1 (с шагом цикла i-- для счетчика второго цикла). OK

namespace HomeWork_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);

            }

            for (int j = 99; j >= 1; j--)
            {
                Console.WriteLine(j);
            }
        }
    }
}
