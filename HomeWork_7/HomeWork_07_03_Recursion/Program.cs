using System;

// 1. Напишіть рекурсивну функцію, яка буде повертати суму вказаної послідовності. Приклад n = 5. Результат 5 + 4 + 3 + 2 + 1 = 15 OK
// 2.Написати рекурсію, яка виводить індекс максимального числа в масиві. Функція має виглядати так
// static int MaxValue(int[] array, int index) OK
//3. Зробити 2 попередні завдання через цикл OK

namespace HomeWork_07_03_Recursion 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 
            int n = 5;
            int summ = 0;
            for (int i = 1; i <= n; i++)
            {
                summ += i;
            }

            Console.WriteLine(summ);

            // 2

            int[] numbs = { -2, 6, 12, -10, 50, 40 };

            int maxNumber = numbs[0];
            int maxIndex = 0;
            for (int i = 0; i < numbs.Length; i++)
            {
                if (numbs[i] > maxNumber)
                {
                    maxNumber = numbs[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine(maxNumber);
            Console.WriteLine(maxIndex);

        }
    }
}
