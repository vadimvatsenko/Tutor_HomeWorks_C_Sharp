using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.Сделать программу, которая определяет является ли число четным или не является, число вводит пользователь 

namespace HomeWork_1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a % 2 == 0);
        }
    }
}