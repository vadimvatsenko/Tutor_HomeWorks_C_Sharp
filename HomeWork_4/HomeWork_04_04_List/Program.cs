using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Есть список { "Tom", "Bob", "Asen", "Klimbo","Muran" }. Отсортируйте список в алфавитном порядке OK

namespace HomeWork_04_04_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Tom", "Bob", "Asen", "Klimbo", "Muran" };

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
