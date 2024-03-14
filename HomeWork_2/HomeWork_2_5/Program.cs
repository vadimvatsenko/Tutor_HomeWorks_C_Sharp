using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5.Запросите ввести 10 целых чисел. Выведите сумму введенных чисел.
// 1  -5  -12   2   3   9   -1  9   5   -8   => сумма = 3 OK
namespace HomeWork_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            int number = 0;
            int total = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Введите число {i}: ");
                number = int.Parse(Console.ReadLine());
                total += number;
            }

            Console.WriteLine(total);
        }
    }
}
