using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Insurance // страховка
    {
        private static int NextNumber = 1;
        public int Number { get; private set; } = 0;
        public User User { get; private set; }
        public string CompanyName { get; private set; }
        public DateTime IssueDate { get; private set; } // дата оформления
        public DateTime Validity {  get; private set; } // дата завершения
        public double SumInsured { get; private set; }

        public Insurance(User user, string companyName, DateTime issueDate, double sumInsured) 
        {
            Number = NextNumber++;
            User = user;
            CompanyName = companyName;
            IssueDate = issueDate;
            Validity = issueDate.AddYears(1);
            SumInsured = sumInsured;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Number = {Number}, \n" +
                $"User = {User.FirstName} - {User.SecondName}, \n" +
                $"Company = {CompanyName}, \n" +
                $"IssueDate = {IssueDate}, \n" +
                $"Validity = {Validity}, \n" +
                $"SumInsured = {SumInsured}");
        }
    }
}
