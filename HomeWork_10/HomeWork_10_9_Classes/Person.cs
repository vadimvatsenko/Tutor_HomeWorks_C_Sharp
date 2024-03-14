using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_9_Classes
{
    internal class Person
    {
        private string name;
        private int age;
        private float[] salary = new float[5];

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float[] Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void Print()
        {
            Console.Write($"Name: {name}, Age: {age}, Salaries: ");
            foreach (var item in Salary)
            {
                Console.Write($" {item}");

            }
            Console.WriteLine($", Total Salary: {TotalSalary()}");
            Console.WriteLine();
        }

        public float TotalSalary()
        {
            float total = 0;
            foreach (float sel in salary)
            {
                total += sel;
            }
            return total;
        }

    }
}
