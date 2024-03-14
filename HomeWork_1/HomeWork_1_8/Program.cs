using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 8. Дано двухзначное число.
// Вывести отдельно его десятичный разряд и разряд единиц (операторы %, /) состоит из цифр 5 и 6, но не -5 и -6.
// Чтобы вывести модуль числа Math.Abs(number);
//Пример
//Введите число:
//50
//Результат: единицы 0, десятки 5
//Введите число:
//-76
//Результат: единицы 6, десятки 7
//OK

namespace HomeWork_1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int numb = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine($"единицы = {numb % 10}, десятки = {numb / 10}");

        }
    }
}
