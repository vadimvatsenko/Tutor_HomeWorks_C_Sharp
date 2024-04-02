using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Создайте функцию, которая принимает массив чисел по ссылке и  параметр с модификатором out.
// Функция возвращает среднее арифметическое этих чисел. Результат должен записываться в параметр с модификатором out

namespace HomeWork_06_05_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = { 1, 5, 10, 20, 60, 100 };

            Average(numbs, out double result);

            Console.WriteLine(result);
        }

        static void Average(int[] nums, out double result)
        {
            int sum = 0;    
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            result = sum / nums.Length;
        }
    }
}
