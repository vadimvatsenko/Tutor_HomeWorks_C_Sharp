using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Создать перечисление Month и поместить туда 3 месяца зимы,
// сделайте так что бы индекс декабря был 12, индекс января был 1,
// а индекс февраля - 2. Выведите индекс каждого месяца. OK

namespace HomeWork_05_01_Enum
{
    enum Month
    {
        December = 12,
        January = 1,
        February = 2,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Month.January);
            Console.WriteLine((int)Month.February);
            Console.WriteLine((int)Month.December);

        }
    }
}
