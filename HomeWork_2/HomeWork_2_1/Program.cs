using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Запросить пользователя ввести число (N). Создайте простой цикл for с N повторениями, который отображает значения счетчика цикла.

namespace HomeWork_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
