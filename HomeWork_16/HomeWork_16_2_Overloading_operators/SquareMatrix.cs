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
    public class SquareMatrix
    {
        public int[,] matrixArray { get; private set; }

        public SquareMatrix(int rows, int cols, int[] matrixNumbers) // цикл
        {
            matrixArray = new int[rows, cols]; // нужно обязательно инициализировать массив!!!

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++) 
                {
                    matrixArray[i,j] = matrixNumbers[i * cols + j ];
                }
            }         
        }

        public void Print()
        {
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    Console.Write(matrixArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static SquareMatrix operator +(SquareMatrix matrix1, SquareMatrix matrix2)
        {
            int[] numb1 = new int[matrix1.matrixArray.GetLength(0) * matrix1.matrixArray.GetLength(1)];

            for (int i = 0; i < matrix1.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] = matrix1.matrixArray[i, j];
                }
            }

            for (int i = 0; i < matrix2.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] += matrix2.matrixArray[i, j];
                }
            }

            SquareMatrix squareMatrix = new SquareMatrix(matrix1.matrixArray.GetLength(0), matrix1.matrixArray.GetLength(1), numb1);
            return squareMatrix;
        }

        public static SquareMatrix operator -(SquareMatrix matrix1, SquareMatrix matrix2)
        {
            int[] numb1 = new int[matrix1.matrixArray.GetLength(0) * matrix1.matrixArray.GetLength(1)];

            for (int i = 0; i < matrix1.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] = matrix1.matrixArray[i, j];
                }
            }

            for (int i = 0; i < matrix2.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] -= matrix2.matrixArray[i, j];
                }
            }

            SquareMatrix squareMatrix = new SquareMatrix(matrix1.matrixArray.GetLength(0), matrix1.matrixArray.GetLength(1), numb1);
            return squareMatrix;
        }

        public static SquareMatrix operator *(SquareMatrix matrix1, SquareMatrix matrix2)
        {
            int[] numb1 = new int[matrix1.matrixArray.GetLength(0) * matrix1.matrixArray.GetLength(1)];

            for (int i = 0; i < matrix1.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] = matrix1.matrixArray[i, j];
                }
            }

            for (int i = 0; i < matrix2.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] *= matrix2.matrixArray[i, j];
                }
            }

            SquareMatrix squareMatrix = new SquareMatrix(matrix1.matrixArray.GetLength(0), matrix1.matrixArray.GetLength(1), numb1);
            return squareMatrix;
        }

        public static SquareMatrix operator *(SquareMatrix matrix1, int numb)
        {
            int[] numb1 = new int[matrix1.matrixArray.GetLength(0) * matrix1.matrixArray.GetLength(1)];

            for (int i = 0; i < matrix1.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrixArray.GetLength(1); j++)
                {
                    numb1[i * matrix1.matrixArray.GetLength(1) + j] = matrix1.matrixArray[i, j] * numb;
                }
            }

            SquareMatrix squareMatrix = new SquareMatrix(matrix1.matrixArray.GetLength(0), matrix1.matrixArray.GetLength(1), numb1);
            return squareMatrix;
        }
    }
}

