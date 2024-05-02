using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Создайте делегат, который принимает массив целых чисел и возвращает их сумму.
// Затем создайте метод, который использует этот делегат для вычисления суммы чисел в массиве. 

namespace HomeWork_08_04_Delegate
{
    delegate int SummArrayDelegate(int[] array);
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbsArray = new int[10];
            for (int i = 0; i < numbsArray.Length; i++)
            {
                numbsArray[i] = rnd.Next(0, 101);
            }
            SummArrayDelegate summArray = SummArray;

            Console.WriteLine(summArray?.Invoke(numbsArray));
        }

        static int SummArray(int[] array)
        {
            int summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }

            return summ;

        }
    }

}
