using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Salary // Заработная плата
    {
        public string EmployeeID { get; private set; } // ID сотрудника или пользователя

        public double EmployeeMoney; // значение зп
        public DateTime dateTimeSalary {  get; private set; } // дата 
        public int OrderForSelaryID { get; private set; } // номер id ордера


        public Salary(User employee, DateTime dateTime, double employeeMoney)
        {
            OrderForSelaryID = IDGenerator.GenerateNumberID(4);
            EmployeeID = employee.UserID;
            dateTimeSalary = dateTime;
            EmployeeMoney = employeeMoney;
        }
    }
}

// DONE
