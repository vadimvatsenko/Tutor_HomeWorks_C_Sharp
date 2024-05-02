using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_1_Events
{
    public class User
    {
        public delegate void AccountHandler(string message);
        private AccountHandler? notify;

        public event AccountHandler Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"{value.Method.Name} удален");
            }
        }

        private string UserName;
        public string UserPassword { get; private set; }

        public User(string name, string password)
        {
            UserName = name;
            UserPassword = password;
            
        }

        public void ChangePassword(string newPassword)
        {
            UserPassword = newPassword;//

            // notify?.Invoke($"NewPassword добавлен");
            notify?.Invoke($"{UserName} изменил пароль на {newPassword}");//
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"UserName: {UserName}, UserPassword: {UserPassword}");
        }
    }     
}
