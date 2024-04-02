using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 11. Создайте перечисление ListOperation со значениями Insert, Add, Remove, RemoveAt.
// Создайте функцию, которая принимает список чисел и перечисление ListOperation.
// Функция должна выполнять операцию, которая передается в качестве второго параметра и возвращать в качестве результата список.
// Более подробно
// Пользователь ввел Insert.
// Дальше нужно предложить что бы пользователь ввел индекс и значение.
// Дальше вставить значение на введенный индекс и вернуть список.
// Так должно быть и с другими вариантами. Можно использовать как switch так и if.

namespace HomeWork_06_11_Method
{
    enum ListOperation
    {
        Insert,
        Add,
        Remove,
        RemoveAt
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                ints.Add(rnd.Next(-100, 101));
            }

            EnterOperationMessage();

            if(Enum.TryParse(Console.ReadLine(), out ListOperation operation))
            {
                Console.WriteLine($"Выбрана операция: {operation.ToString()}");
            } else
            {
                Console.WriteLine($"Нет такой операции");
                EnterOperationMessage();
            }


            Operation(ints, operation);

            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
            
        }

        static void EnterOperationMessage()
        {
            Console.WriteLine("Введите значение: \n" +
                "Insert \n" +
                "Add \n" +
                "Remove \n" +
                "RemoveAt");
        }

        static void Operation(List<int> list, ListOperation oper) 
        { 
            switch (oper)
            {
                case ListOperation.Insert:
                    list.Insert(0, 2809); 
                    break;
                case ListOperation.Add:
                    list.Add(0108);
                    break;
                case ListOperation.Remove:
                    list.Remove(10);
                    break;
                case ListOperation.RemoveAt:
                    list.RemoveAt(2);
                    break;
                default:
                    throw new Exception("Error");

            }
        }
    }
}
