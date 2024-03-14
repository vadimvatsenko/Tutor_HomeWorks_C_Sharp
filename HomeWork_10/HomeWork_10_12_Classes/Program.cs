using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Создайте класс BankAccount, представляющий банковский счет,
//и реализуйте в нем следующее: закрытое статическое поле: interestRate, представляющее годовую процентную ставку для всех счетов.
//Установите начальное значение в 0.05 (5%).
//Публичное статическое свойство InterestRate,
//который позволяет устанавливать новое значение для interestRate.
//Метод должен проверять, что переданное значение находится в пределах от 0 до 1, включительно.
//Приватное поле: Добавьте поле balance для хранения текущего баланса счета.
//Для него создайте геттер. Экземплярные методы: Реализуйте методы Deposit и Withdraw,
//позволяющие вносить деньги на счет и снимать их соответственно.
//Учтите проверки на отрицательные суммы и достаточность средств.
//Реализуйте публичный метод ApplyInterest для применения  процентной ставки
//Демонстрация использования: В основной программе создайте несколько счетов,
//устанавливая различные процентные ставки с использованием статического метода.
//Произведите несколько операций по внесению и снятию средств для каждого счета. Выведите информацию о каждом счете, включая примененные проценты.

namespace HomeWork_10_12_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            BankAccount.InterestRate = 0.06f;

            account1.Deposit(1000);
            BankAccount.InterestRate = 0.03f;
            account2.Deposit(500);


            account1.Withdraw(200);
            account2.Withdraw(100);

            account1.ApplyInterest();
            account2.ApplyInterest();

            //Console.WriteLine($"Account 1 Balance : {account1.Balance}");//824
            //Console.WriteLine($"Account 1 Balance : {account2.Balance}");// 412

            Human h = new Human();
            h.Name = "H";
            Calc(ref h);
            Console.WriteLine(h.Name);
        }

        static void Calc(ref Human human)
        {
            human = new Human();
            human.Name = "N";

        }
    }

    class Human
    {
        public string Name { get; set; }
    }
}
