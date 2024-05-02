using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Employee
    {
        public string EmployeeID { get; private set; }
        public string EmployeeFirstName { get; private set;}
        public string EmployeeSecondName { get; private set;}

        public Employee(string firstName, string secondName)
        {
            EmployeeID = IDGenerator.GenerateID(6);
            EmployeeFirstName = firstName;
            EmployeeSecondName = secondName;
        }

    }
}
