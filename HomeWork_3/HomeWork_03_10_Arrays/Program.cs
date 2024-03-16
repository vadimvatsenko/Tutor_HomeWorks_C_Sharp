using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Есть массив  { -6, 34, 0, -1,57, 2, 36, 7 };.
// Отсортируйте массив от минимального к максимальному: {-6, -1, 0, 2,7,34, 36,57}

namespace HomeWork_03_10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -6, 34, 0, -1, 57, 2, 36, 7 };
            //int[] b = new int[a.Length];



            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    } 
                }
            }

            for (int i = 0;i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            
        }
        
    }
}
