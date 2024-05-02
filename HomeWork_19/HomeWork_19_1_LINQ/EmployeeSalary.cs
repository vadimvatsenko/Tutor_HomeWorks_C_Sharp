using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class EmployeeSalary
    {
        private static int NextNumber = 1;
        public int OrderForSelary { get; private set; } = 0;
        public string EmployeeID { get; private set; }
        public DateTime dateTimeSalary {  get; private set; }

        public double EmployeeMoney;

        public EmployeeSalary(Employee employee, DateTime dateTime, double employeeMoney)
        {
            OrderForSelary = NextNumber++;
            EmployeeID = employee.EmployeeID;
            dateTimeSalary = dateTime;
            EmployeeMoney = employeeMoney;
        }

    }
}
