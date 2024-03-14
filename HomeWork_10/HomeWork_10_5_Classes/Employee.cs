using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_5_Classes
{
    internal class Employee
    {
        public string firstName;
        public string secondName;
        public WorkPlace workPlace = new WorkPlace();

        public void Print()
        {
            Console.WriteLine($"Employee {firstName} {secondName}, workPlace {workPlace.Experience}"); // доступ к полу через set
        }
    }
}
