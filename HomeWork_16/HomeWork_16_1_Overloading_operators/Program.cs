using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создайте перегрузку для вашего класса Vector3.
// Реализуйте возможность суммирования 2 векторов, разность 2 векторов,
// инкремента, умножение числа на вектор,
// сравнение векторов и перегрузку оператора !=
//Перегрузку оператора != реализовать через оператор ==

namespace HomeWork_16_1_Overloading_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3 v1 = new Vector3(10, 20, 30);
            Vector3 v2 = new Vector3(10, 20, -30);
            Vector3 v3 = new Vector3(10, 60, -10);
            Vector3 v4 = new Vector3(17, 30, 14);
           
            Vector3 summ = v1 + v2;
            Vector3 minus = v1 - v2;

            Console.WriteLine($"{summ.x} {summ.y} {summ.z}");
            Console.WriteLine($"{minus.x} {minus.y} {minus.z}");


            v3++;
            Console.WriteLine($"{v3.x} {v3.y} {v3.z}");

            Vector3 v5 = v4 * 15;
            Console.WriteLine($"{v5.x} {v5.y} {v5.z}");

            Console.WriteLine(v1 > v2);

            Console.WriteLine(v1 == v2);
            Console.WriteLine(v1 != v2);
        }
    }
}
