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

namespace HomeWork_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1 - Сложение";
            string b = "2 - Вычитание";
            string c = "3 - Умножение";

            Console.WriteLine($"Введите номер операции: \n" +
                $"{a} \n" +
                $"{b} \n" +
                $"{c}");

            int numb = int.Parse(Console.ReadLine());

            switch(numb)
            {
                case 1:
                    Console.WriteLine(a); break;
                case 2:
                    Console.WriteLine(b); break;
                case 3:
                    Console.WriteLine(c); break;
                default:
                    Console.WriteLine("операция не определена"); break;
            }
        }
    }
}
