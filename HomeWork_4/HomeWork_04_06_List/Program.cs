using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Есть список char с элементами ‘b’,’a’,’a’,’n’.
// С помощью метода Insert сделайте так, что бы список стал таким ‘b’,’a’,’n’,’a’,’n’ и выведите на экран ОК

namespace HomeWork_04_06_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> ch = new List<char>() {'b', 'a', 'a', 'n' };

            ch.Insert(2, 'n');

            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }
        }
    }
}
