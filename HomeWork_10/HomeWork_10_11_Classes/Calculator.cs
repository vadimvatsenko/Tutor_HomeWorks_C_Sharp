using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_11_Classes
{
    public class Calculator
    {
        public int Calculate(int x, int y)
        {
            return x + y;
        }

        public double Calculate(double x, double y)
        {
            double difference = x - y;

            /*if (difference >= 0) // еще пример абсолютной величины
            {
                return difference;
            } else
            {
                return -difference;
            }*/
            return Math.Abs(difference); // Math.Abs - абсолютная величина
        }

        public string Calculate(string x, string y)
        {
            return x + ' ' + y; // конкатенация строк 
        }
    }
}
