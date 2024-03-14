using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_2_Inheritance
{
    internal class User
    {
        private int userId;
        private string userName;
        private string userPassword;
        private string userAddress;

        public int UserId
        {
            get { return userId; }
            private set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }
        public string UserPassword
        {
            get { return userPassword; }
            private set { userPassword = value; }
        }
        public string UserAddress
        {
            get { return userAddress; }
            private set { userAddress = value; }
        }

        public User(int id, string userName, string password, string adress)
        {
            UserId = id;
            UserName = userName;
            UserPassword = password;
            UserAddress = adress;

        }

        public void Print()
        {
            Console.WriteLine($"userId = {UserId}, userName = {UserName}, userPassword = {UserPassword}, userAdress = {UserAddress}");

        }


    }
}
