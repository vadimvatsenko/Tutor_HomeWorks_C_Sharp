using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Напишите консольную программу, которая выводит пользователю сообщение
// "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение".
// Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2.
// Пусть пользователь вводит в программу номер операции,
// и в зависимости от номера операции программа выводит ему название операции.

//Для определения операции по введенному номеру используйте конструкцию switch...case.
//Если введенное пользователем число не соответствует никакой операции (например, число 120),
//то выведите пользователю сообщение о том, что операция не определена. OK

// 2.Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа,
// и в зависимости от номера операции с введенными числами выполняются определенные действия
// (например, при вводе числа 3 числа умножаются).
// Результата операции выводиться на консоль. OK



namespace HomeWork_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; int y;

            string a = "1 - Сложение";
            string b = "2 - Вычитание";
            string c = "3 - Умножение";

            Console.WriteLine("Введите первое число");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите номер операции: \n" +
                $"{a} \n" +
                $"{b} \n" +
                $"{c}");

            int numb = int.Parse(Console.ReadLine());

            switch (numb)
            {
                case 1:
                    Console.WriteLine(x + y); break;
                case 2:
                    Console.WriteLine(x - y); break;
                case 3:
                    Console.WriteLine(x * y); break;
                default:
                    Console.WriteLine("операция не определена"); break;
            }
        }
    }
}