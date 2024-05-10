using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class User // пользователь
    {
        public int UserID { get; private set; } // ID пользователя
        public string FirstName { get; private set; } // имя
        public string SecondName { get; private set; } // фамилия
        public string Phone { get; private set; } // телефон

        public User(string firstName, string secondName, int phone)
        {
            UserID = IDGenerator.GenerateNumberID(10);
            FirstName = firstName;
            SecondName = secondName;
            Phone = phone.ToString("+38 (###) ###-##-##");
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

//Done
