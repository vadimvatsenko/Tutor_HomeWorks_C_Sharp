using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Создайте массив на 10 элементов и заполните его рандомными числами.
// Найдите для каждого элемента корень квадратный и перезапишите результат в тот же элемент

namespace HomeWork_03_03_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] numbs = new int[10];

            for(int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = rnd.Next(-20, 20);
            }

            foreach(int i  in numbs) Console.WriteLine(i);

            Console.WriteLine("+++");

            for (int i = 0;i < numbs.Length; i++)
            {
                numbs[i] = (int)Math.Sqrt(numbs[i]);
            }

            foreach(int i in numbs) Console.WriteLine(i);
        }
    }
}
