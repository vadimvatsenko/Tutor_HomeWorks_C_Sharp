using System;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

// 1. задача, найти все простые числа в диапазоне до 10000
// 2. Суммировать эти числа
// 3. Потом суммировать числа полученного числа 

// простое число делится на самого себя, и не делится на предыдущие числа

// простое
// 5 / 1 = правда
// 5 / 2 = не
// 5 / 3 = не
// 5 / 4 = не
// 5 / 5 = да

// простое
// 3 / 1 = да
// 3 / 2 = не
// 3 / 3 = да

// не простое 
// 4 / 1 = да
// 4 / 2 = да
// 4 / 3 = нет
// 4 / 4 = да

// простое
// 2 / 1 = да
// 2 / 2 = да

// 10250
// длинна 5 сим;

namespace Lesson 
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int summ = 0;
            
            for (int i = 2; i <= 10000; i++) 
            {
                int counter = 0;
                for (int j = i; j > 0; j--)
                {
                    if(i % j == 0)
                    {
                        counter++;
                    } 
                }

                if(counter < 3) 
                {
                    summ += i;
                }
            }

            Console.WriteLine($"summ = {summ}");

            int endSumm = 0;

            for (int i = 1; i < summ; i*=10)
            {
                int numb = summ % (10 * i) / i;
                endSumm += numb;
            }

            Console.WriteLine(endSumm);

        }
    }
}    
