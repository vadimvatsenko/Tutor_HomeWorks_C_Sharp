using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Вводятся 10 вещественных чисел. Вывести их произведение. 
namespace HomeWork_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int summ = 1;
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"Введите {i} число");
                int numb = int.Parse(Console.ReadLine());
                summ *= numb;
            }

            Console.WriteLine(summ);
        }
    }
}
