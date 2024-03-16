using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. Дан целочисленный массив (15 элементов, сгенерированных случайным образом в диапазоне от 1 до 10).
//Требуется определить, есть ли в массиве элемент, равный N (N вводится).
//Выведите «да» или «нет» один раз. Для поиска элемента используйте цикл foreach.

namespace HomeWork_03_06_Arrays
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numb");
            int enterNumb = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] numbs = new int[15];

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = rnd.Next(1, 11);
            }


            bool isFound = false;
            foreach (int i in numbs)
            {
                if(i == enterNumb)
                {
                    // Console.WriteLine($"число {enterNumb} = {i}");
                    isFound = true;
                } 
               
            }

            if(isFound)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
