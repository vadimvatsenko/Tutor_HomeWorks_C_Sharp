using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Создайте класс Employee и класс WorkPlace.
// Класс Employee должен содержать публичные поля: имя, фамилия и объект класс WorkPlace.
// Класс WorkPlace должен содержать приватное поле стаж, которое можно инициализировать с помощью свойства.
// Обязательно проверьте на то является ли стаж отрицательным числом.
// Создайте 3 объекта сотрудника и проинициализируйте все его поля с помощью инициализатора.
// Создайте список и покажите сотрудника с наибольшем стажем работы. 

namespace HomeWork_10_5_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee()
            { firstName = "Vadym", secondName = "Vatsenko", workPlace = { Experience = 5f } };
            // все его поля с помощью инициализатора
            Employee employee2 = new Employee()
            { firstName = "Irina", secondName = "Vatsenko", workPlace = { Experience = 12f } };
            // все его поля с помощью инициализатора
            employee.Print();
            employee2.Print();

            List<Employee> list = new List<Employee>();
            list.Add(employee);
            list.Add(employee2);



            float minValue = list[0].workPlace.Experience; // первый из списка
            Employee emp = new Employee();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].workPlace.Experience > minValue)
                {
                    minValue = list[i].workPlace.Experience;
                    emp = list[i];
                }
            }

            emp.Print();
        }
    }
}
