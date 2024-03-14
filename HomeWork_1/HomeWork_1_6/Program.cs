using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Пользователь вводит целое число,
// преобразуйте значение номера дня недели в текстовое название.
// Если введенное значение не соответствует дню недели,
// выведите сообщение об ошибке. Сделать с помощью switch case OK

namespace HomeWork_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер недели");
            int numb = int.Parse(Console.ReadLine());

            switch (numb)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default: Console.WriteLine("Ошибка");
                        break;

            }
        }
    }
}
