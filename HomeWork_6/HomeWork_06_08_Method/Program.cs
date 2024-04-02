using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 8. Создайте функцию PosNegSeq(), которая принимает три,
// первые два аргумента по ссылке — счетчики положительных чисел последовательности и отрицательных чисел и третий это аргумент с модификатором out.
// Пользователь вводит последовательность целых чисел, завершая ввод 0.
// Функция должна посчитать количество отрицательных и положительных чисел и записать ответ в третий параметр

/*Введите последовательность, завершите ввод 0
	2  -4  8  -3  5  0
	кол-во отрицательных: 2, количество положительных: 3

    Чтобы ввести числа последовательности необходимо использовать цикл
	 
  int a = 0;
do
{
    a = Convert.ToInt32(Console.ReadLine());
}
while (a != 0);*/

namespace HomeWork_06_08_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int positiveCounter = 0;
            int negativeCounter = 0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a != 0);

            PosNegSeq(ref positiveCounter, ref negativeCounter, out a);
        }

        static void PosNegSeq(ref int positive, ref int negative, out int number )
        {
            number = 2;
        }
    }
}
