using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Присоедините еще один метод к нему, который также принимает 2 числа,
// но возвращает возведение числа в степень.
// Вызовите делегат. Потом отсоедините второй метод и покажите как сработает делегат 

namespace HomeWork_08_02_Delegate
{
    internal class Program
    {
        delegate double Numbers(int a, int b);
        


        static void Main(string[] args)
        {
            Numbers summNumb;
            summNumb = Summ;
            Console.WriteLine(summNumb?.Invoke(2, 6));

            Numbers expo = Exponentiation;
            Console.WriteLine(expo?.Invoke(2, 6));
        }

        static double Summ(int a, int b)
        {
            return a + b;
        }

        static double Exponentiation(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }
}
