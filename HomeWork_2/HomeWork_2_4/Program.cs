using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 4.Для ввода чисел создайте цикл for.
// В теле цикла проверяйте, положительное ли число введено или отрицательное.
// Используйте две переменных-счетчика (увеличивающихся на единицу)
// для подсчета количества положительных
// и отрицательных чисел.
//	1  -5  -12   2   3   9   -1  9   5   -8   => количество положительных = 6, количество отрицательных = 4  OK

namespace HomeWork_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int positiveNumber = 0;
            int negativeNumber = 0;

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Введите число");
                int numb = int.Parse(Console.ReadLine());
                if(numb < 0) 
                {
                    negativeNumber++;
                } else if (numb >= 0) 
                {
                    positiveNumber++;
                }
            }

            Console.WriteLine($"количество положительных = {positiveNumber}");
            Console.WriteLine($"количество отрицательных = {negativeNumber}");

        }
    }
}
