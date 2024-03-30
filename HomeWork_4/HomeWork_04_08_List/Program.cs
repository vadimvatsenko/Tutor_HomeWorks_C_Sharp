using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 8. Создайте список с именами.
// Пускай пользователь введет имя и если такое имя есть в списке,
// то выведите количество совпадений и индексы этих имен ОК

namespace HomeWork_04_08_List
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
            string enteredName = Console.ReadLine();

            int nameCounter = 0;

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == enteredName)
                {
                    nameCounter++;
                    Console.WriteLine($"Индексы имён {i}") ;
                }
            }


            Console.WriteLine($"количество совпавших имён {nameCounter}");
        }
    }
}
