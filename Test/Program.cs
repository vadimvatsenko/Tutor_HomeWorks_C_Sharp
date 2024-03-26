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
            Counter counter1 = new Counter() { Value = 23 };
            Counter counter2 = new Counter() { Value = 45 };

            bool result = counter1 > counter2;
            Counter counter3 = counter1 + counter2;
            int summ = counter1 + 27;

            Console.WriteLine(result);
            Console.WriteLine(counter3.Value);
            Console.WriteLine(summ);

            Counter counter4 = new Counter() { Value = 10 };
           /* Counter counter5 = counter4++;
            Console.WriteLine(counter4.Value);
            Console.WriteLine(counter5.Value);*/

            Counter counter6 = ++counter4;
            Console.WriteLine(counter4.Value);
            Console.WriteLine(counter6.Value);

        }
    }

    class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter a, Counter b)
        {
            return new Counter
            {
                Value = a.Value + b.Value
            };
        }

        public static Counter operator ++(Counter a)
        {
            return new Counter { Value = a.Value + 10 };
        }

        public static int operator +(Counter a, int val)
        {
            return a.Value + val;
        }

        public static bool operator >(Counter a, Counter b) 
        {   
            return a.Value > b.Value;
        }

        public static bool operator <(Counter a, Counter b)
        {
            return a.Value < b.Value;
        }
    }
}
