using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Дана переменная int Number.
// Пускай пользователь вводит число в эту переменную.
// С помощью тернарного оператора определите это положительное число или отрицательное и выведите на экран 
namespace HomeWork_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a >= 0 ? true: false) ;
        }
    }
}
