using System;


// Создать класс User с зарытыми полями name и password. Создать свойство для поля password.
// Создать конструктор. Создать делегат, который принимает строку, создать соответствующее закрытое событие,
// через которое будут добавляться и удалятся новые обработчики только в классе.
// Создать публичное событие для подписи обработчиков за пределами класса.
// Создать в классе метод Print и метод OnChangePassword, который принимает строку.
// В Main создать обработчик который будет оповещать о том, что пароль изменен. 

namespace HomeWork_18_1_Events 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User("Vadym", "qwerty");
            newUser.PrintUserInfo();
            newUser.Notify += DisplayMessage; // добавлен

            newUser.ChangePassword("password");
            newUser.PrintUserInfo();
            newUser.Notify -= DisplayMessage;

            void DisplayMessage(string message) => Console.WriteLine(message);

           

            
        }
    }
}
