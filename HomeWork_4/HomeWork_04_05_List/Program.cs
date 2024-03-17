using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создайте список с 20 элементами. Удалить все нечетные элементы списка ОК

namespace HomeWork_04_05_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> numb = new List<int>(20);

            for (int i = 0; i < 20; i++) 
            {
                numb.Add(rnd.Next(0, 101));
            }

            for (int i = 0;i < numb.Count;i++)
            {
                Console.WriteLine(numb[i]);
            }

            Console.WriteLine("+++++");
            for (int i = 0; i < numb.Count; i++) 
            {
                numb.RemoveAll(x => x % 2 != 0);
            }

            foreach (int i in numb)
            {
                Console.WriteLine(i);
            }
        }
    }
}
