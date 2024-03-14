using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 2. Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
// Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10".
// Иначе программа выводит сообщение "Неизвестное число". ОК

namespace HomeWork_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb;
            Console.WriteLine("Enter Number");
            string enterNumb = Console.ReadLine();

            numb = int.Parse(enterNumb);

            if(numb == 5 || numb == 10 )
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
