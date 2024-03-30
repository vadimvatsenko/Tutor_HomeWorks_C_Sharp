using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Создайте класс SquareMatrix и создайте в нем поле массив чисел и поле размер матрицы.
// Конструктор должен инициализировать массив. Реализовать операторы +, -, *.
// Также реализовать умножение числа на матрицу. 


namespace HomeWork_16_2_Overloading_operators
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbs1 = new int[25];
            int[] numbs2 = new int[25];

            for (int i = 0; i < 25; i++)
            {
                numbs1[i] = random.Next(0, 101);
                numbs2[i] = random.Next(0, 101);
            }

            SquareMatrix matrix1 = new SquareMatrix(5, 5, numbs1);
            SquareMatrix matrix2 = new SquareMatrix(5, 5, numbs2);

            matrix1.Print();
            Console.WriteLine();
            matrix2.Print();

            Console.WriteLine("+");

            SquareMatrix matrix3 = matrix1 + matrix2;
            matrix3.Print();

            Console.WriteLine("-");

            SquareMatrix matrix4 = matrix1 - matrix2;
            matrix4.Print();

            Console.WriteLine("x");

            SquareMatrix matrix5 = matrix1 * matrix2;
            matrix5.Print();

            Console.WriteLine("x 5");

            SquareMatrix matrix6 = matrix1 * 5;
            matrix6.Print();
           
        }
    }
}
