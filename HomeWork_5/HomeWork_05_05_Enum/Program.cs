using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создать перечисление с названием ListController с вариантами Clear, Sort и Reverse.
// Создать список и заполнить рандомно его на 10 элементов.
// Пользователь вводит строку со значением Clear, Sort или Reverse.
// С помощью if else выполнить необходимую операцию,
// преобразовать перечисление в строку можно с помощью Название_Перечисления.Вариант.toString() OK

namespace HomeWork_05_05_Enum
{
    enum ListController
    {
        Clear,
        Sort,
        Reverse,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:\n" +
                "Clear \n" +
                "Sort \n" +
                "Reverse");

            string operation = Console.ReadLine();

            Random rand = new Random();
            List<int> numbs = new List<int>(10);

            for (int i = 0; i < numbs.Capacity; i++)
            {
                numbs.Add(rand.Next(0, 101));
            }
            
            if(operation == ListController.Sort.ToString())
            {
                numbs.Sort();
            }
            else if(operation == ListController.Reverse.ToString())
            { 
                numbs.Reverse(); 
            }
            else if(operation == ListController.Clear.ToString())
            {
                numbs.Clear();
            }

            foreach (int i in numbs)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}
