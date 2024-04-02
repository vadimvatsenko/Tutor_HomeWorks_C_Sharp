using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
            
        static void Main(string[] args)
        {
            int fib4 = Fibonachi(4);
            Console.WriteLine(fib4);
        }

        static int Fibonachi(int i)
        {
            if (i == 0 || i == 1) return i;
            return Fibonachi(i - 1) + Fibonachi(i - 2);
        }
              
    }

}
