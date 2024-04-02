using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Создайте метод Sum(), который принимает два целочисленных аргумента и суммирует их. Метод не возвращает никакого значения 

namespace HomeWork_06_01_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Summ(6, 22);
        }

        static void Summ(int a,  int b) 
        {
            Console.WriteLine(a + b);
        }
    }
}
