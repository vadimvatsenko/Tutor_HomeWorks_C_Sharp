using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 9.Дополните задание 6 и пускай пользователь вводит число,
// которое будет характеризовать количество символов имени.
// Если в списке есть имена, количество букв которых равно числу, который ввел юзер,
// то выведите эти имена на экран OK


namespace HomeWork_04_09_List
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

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length == enteredNameNumbs)
                {
                    Console.WriteLine(names[i]);
                }              
            }          
        }
    }
}
