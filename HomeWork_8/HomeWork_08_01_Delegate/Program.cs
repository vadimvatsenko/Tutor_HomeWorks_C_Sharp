using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Создайте делегат с названием Numbers, который возвращает число, а принимает 2 параметра. Метод возвращает сумму 2 чисел. 

namespace HomeWork_08_01_Delegate
{
    internal class Program
    {
        delegate int Numbers(int a, int b);

        
        static void Main(string[] args)
        {
            Numbers summNumb;

            summNumb = Summ;

            Console.WriteLine(summNumb?.Invoke(2, 6)); 
            
        }

        static int Summ(int a, int b)
        {
            return a + b;
        }
    }
}
