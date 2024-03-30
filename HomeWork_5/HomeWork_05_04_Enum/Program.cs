using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Создайте переменную int пускай пользователь в нее вводит цифру.
// Создайте перечисление Week, которое будет хранить дни недели.
// Вывести на экран день недели в зависимости от того какое число ввел пользователь,
// использовать switch case.
// Выводить сообщение можно только с помощью записи Название_Перечисления.Вариант.toString() OK

namespace HomeWork_05_04_Enum
{
    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int weekNumber = int.Parse(Console.ReadLine());

            switch (weekNumber)
            {
                case 1:
                    Console.WriteLine(Week.Monday.ToString());
                    break;
                case 2:
                    Console.WriteLine(Week.Tuesday.ToString());
                    break;
                case 3:
                    Console.WriteLine(Week.Wednesday.ToString());
                    break; 
                case 4:
                    Console.WriteLine(Week.Thursday.ToString());
                    break;
                case 5:
                    Console.WriteLine(Week.Friday.ToString());
                    break;
                case 6:
                    Console.WriteLine(Week.Saturday.ToString());
                    break;
                case 7:
                    Console.WriteLine(Week.Sunday.ToString());
                    break;
                default:
                    Console.WriteLine("Ints not day of week");
                    break;
            }
        }
    }
}
