using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class User // пользователь
    {
        public string UserID { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public int Phone { get; private set; }

        public User(string firstName, string secondName, int phone)
        {
            UserID = IDGenerator.GenerateID(10);
            FirstName = firstName;
            SecondName = secondName;
            Phone = phone;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Id = {UserID}, \n" +
                $"FirstName = {FirstName}, \n" +
                $"SecondName = {SecondName}, \n" +
                $"Phone = {Phone}");
        }
       
    }
}
