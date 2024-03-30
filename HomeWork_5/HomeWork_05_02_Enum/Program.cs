using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Создайте перечисление Language{JS,C,PHP}.
// Создайте переменную типа string и запишите
// в нее один из пунктов перечисления и выведите на экран. OK

namespace HomeWork_05_02_Enum
{
    enum Language
    {
        JS,
        C,
        PHP,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string lang = Language.C.ToString();

            Console.WriteLine(lang);
        }
    }
}
