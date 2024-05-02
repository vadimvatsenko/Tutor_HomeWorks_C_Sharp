using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Обращение к элементу массива:
// Создайте массив и попробуйте обратиться к элементу с индексом,
// который выходит за пределы массива. Обработайте исключение IndexOutOfRangeException.

namespace HomeWork_09_03_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbs = new int[15];

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = rnd.Next(-100, 101);
            }

            try
            {
                Console.WriteLine(numbs[16]);
            }
            catch(IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Programm end");
            }
        }
    }
}
