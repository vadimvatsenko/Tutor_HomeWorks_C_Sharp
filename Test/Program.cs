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
            double position = 5;
            double speed = 0.1;
            double height = 3;

            double summ = 0;
            for (double i = 0; i < height; i += speed)
            {
                position = position - i;
                Console.WriteLine(i);
                summ += i;
                
            }
            Console.WriteLine(summ);
            Console.WriteLine(position);

        }
    }
}

    


