using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Сделать предыдущее задание с помощью функции FindAll OK

namespace HomeWork_04_10_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Vadym",
                "Irochra",
                "Busya",
                "Vadym"
            };

            Console.WriteLine("Enter Name");
            int enteredNameNumbs = int.Parse(Console.ReadLine());

            List<string> findNames = names.FindAll(p => p.Length == enteredNameNumbs);

            foreach (string name in findNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
