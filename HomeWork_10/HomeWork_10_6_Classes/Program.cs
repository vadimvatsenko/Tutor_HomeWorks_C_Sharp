using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. С помощью деконструктора получите имя каждого сотрудника и его стаж. Выведите результат на консоль.

namespace HomeWork_10_6_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Vadym", secondName = "Vatsenko", workPlace = { Experience = 5f } };
            Employee employee2 = new Employee() { firstName = "Irina", secondName = "Vatsenko", workPlace = { Experience = -1f } };
            employee1.Print();
            employee2.Print();

            (string name1, _, WorkPlace workPlace1) = employee1;
            (string name2, _, WorkPlace workPlace2) = employee2;


            Console.WriteLine($"name {name1}, workPlace {workPlace1.Experience}");
            Console.WriteLine($"name {name2}, workPlace {workPlace2.Experience}");
        }
    }
}
