using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 6. Программа должна считать сумму 10 чисел следующей последовательности:
// 1 + 3 + 5 + 7 + 9 + 11 + 13 + 15 + 17 + 19
// (числа последовательности НЕ вводятся, а получаются в цикле). OK

namespace HomeWork_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            for (int i = 1; i <= 19; i+=2) 
            {
                summ += i;
            }

            Console.WriteLine(summ);
        }
    }
}
