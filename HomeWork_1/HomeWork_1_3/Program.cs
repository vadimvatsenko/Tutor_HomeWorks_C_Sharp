using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
// Напишите консольную программу, в которую пользователь вводит сумму вклада.
// Если сумма вклада меньше 100, то начисляется 5%.
// Если сумма вклада от 100 до 200, то начисляется 7%.
// Если сумма вклада больше 200, то начисляется 10%.
// В конце программа должна выводить сумму вклада с начисленными процентами.
// Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine()) OK
namespace HomeWork_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numb;
            Console.WriteLine("Пользователь вводит сумму вклада");

            numb = Convert.ToDouble(Console.ReadLine());

            if(numb < 100 && numb > 0) 
            {
                Console.WriteLine(Math.Round(numb + (numb * 0.05f), 2));
            }
            else if( numb >= 100 && numb <= 200)
            {
                Console.WriteLine(Math.Round(numb + (numb * 0.07f), 2));
            }
            else if (numb > 200)
            {
                Console.WriteLine(Math.Round(numb + (numb * 0.1f), 2));
            }

        }
    }
}
