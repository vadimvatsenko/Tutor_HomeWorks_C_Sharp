using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.	Есть переменная int, значение которой = 7. С помощью постфиксального инкремента
// и условного оператора проверьте равно ли эта переменная значению 8.
// Сделайте также с префиксальным инкрементом. ОК

namespace HomeWork_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7; // префиксный инкремент с начало прибавит к переменной а 1цу, потом присвоит ее в b
            int b = ++a;
            Console.WriteLine($"++a: a = {a}, b = {b}"); // а = 8, b = 8;

            int c = 7; // постфиксный инкремент с начало присвоит (c)7ку в d, а потом 1цу прибавит к с
            int d = c++;
            Console.WriteLine($"c++: c = {c}, d = {d}"); // а = 8, d = 7;

            int e = 7;
            int f = --e;
            Console.WriteLine($"--e: e = {e}, f = {f}"); // е = 6, f = 6;

            int g = 7;
            int h = g--;
            Console.WriteLine($"g--: g = {g}, h = {h}"); // g = 6, h = 7;

            int i = 7;
            int j = 7;
            Console.WriteLine(++i == 8); // 8
            Console.WriteLine(j++ == 8); // 7
            int k = 7;
            int l = 7;
            Console.WriteLine(--k == 8);
            Console.WriteLine(k-- == 8);
        }
    }
}
