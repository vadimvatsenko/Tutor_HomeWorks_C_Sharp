using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Попросите пользователя ввести отметку (значения 1, 2, 3, 4, 5).
// Проверьте введенное число, и распечатайте характеристику отметки (very_bad — 1, bad — 2, satisfactory — 3, good — 4, excellent — 5).
// Создайте функцию CheckMark с оператором switch, чтобы проверить введенную отметку. Использовать enum

namespace HomeWork_06_10_Method
{
    internal class Program
    {
        enum Value
        {
            very_bad = 1,
            bad,
            satisfactory,
            good,
            excellent
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 5");
            int a = int.Parse(Console.ReadLine());
            CheckMark(a);
        }

        static void CheckMark(int a) 
        { 
            switch (a)
            {
                case 1:
                    Console.WriteLine(Value.very_bad);
                    break;
                case 2:
                    Console.WriteLine(Value.bad);
                    break;
                case 3:
                    Console.WriteLine(Value.satisfactory);
                    break;
                case 4:
                    Console.WriteLine(Value.good);
                    break;
                case 5:
                    Console.WriteLine(Value.excellent);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
