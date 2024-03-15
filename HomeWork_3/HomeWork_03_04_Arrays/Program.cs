using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Дан массив строк [‘Hello’,’it’,’is’,’me’].
// Сделайте так что бы в конец каждого слова добавился восклицательный знак. [‘Hello!’,’it!’,’is!’,’me!’] 

namespace HomeWork_03_04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Hello", "it", "is", "me" };
            
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i] + "!";
            }

            foreach (string st in str)
            {
                Console.WriteLine(st);
            }
        }
    }
}
