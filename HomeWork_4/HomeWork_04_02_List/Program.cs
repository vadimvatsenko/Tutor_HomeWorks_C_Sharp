using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04_02_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>(10);

            for (int i = 0; i < 10; i++) 
            { 
                list.Add(rnd.Next(0, 101));
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            list.Reverse();

            Console.WriteLine("++++");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
