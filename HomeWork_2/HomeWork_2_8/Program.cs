using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 8. Используйте вложенный цикл for для нахождения всех простых чисел на интервале от n до m, n и m вводит пользователь 

// Простыми числами называют такие натуральные числа больше единицы, которые имеют только два делителя: единицу и само себя.

namespace HomeWork_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число m");
            int m = int.Parse(Console.ReadLine());

            for (int i = n; i < m; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                    continue;
                }
                if (i % 2 == 0 || i <= 1) continue;
                bool isPrime = true;

                for (int j = 3; j * j <= i; j += 2)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) Console.WriteLine(i);
            }
        }
    }
}


// 
