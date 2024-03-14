using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Создайте класс "Person" в C#, который представляет человека и имеет закрытые поля для имени,
//возраста а также массив чисел на 5 элементов, который представляет собой заработные платы за каждый месяц
//и открытые соответствующие свойства. Используйте свойства get и set для доступа к этим данным.
//Затем создайте список объектов этого класса и установите значения для имени, возраста и заработных плат с использованием свойств.
//Реализуйте метод Print для вывода информации о человеке на консоль.
//Выведите имя человека, который получил больше всего денег за 5 месяцев.

namespace HomeWork_10_9_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Vadym", Age = 39, Salary = new float[5] {80000, 75000, 60000, 40000, 50000 } }, // инициализация
                new Person() {Name = "Nazar", Age = 28, Salary = new float[5] { 90000, 80000, 100000, 105000, 110000 } },
                new Person() {Name = "Irina", Age = 39, Salary = new float[5] { 20000, 20000, 22500, 23000, 25000 } },
                new Person() {Name = "Olga", Age = 68, Salary = new float[5] { 10000, 15000, 30000, 23000, 11000 } },
                new Person() {Name = "Nikolay", Age = 63, Salary = new float[5] { 15000, 14000, 12000, 11100, 50000 } },
            };

            foreach (var person in people)
            {
                person.Print();
            }

            Console.WriteLine("====================");

            MostReachPerson(people);
        }

        static void MostReachPerson(List<Person> people)
        {
            float biggestSallary = people[0].TotalSalary();
            Person MostReachPerson = null;

            foreach (var person in people)
            {
                if (biggestSallary < person.TotalSalary())
                {
                    biggestSallary = person.TotalSalary();
                    MostReachPerson = person;
                }
            }

            MostReachPerson.Print();
            Console.WriteLine(MostReachPerson.Name);
        }
    }
}
