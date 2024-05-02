using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Создайте метод, который принимает число.
//Внутри метода нужно реализовать исключение throw если число отрицательное и метод должен возвращать корень квадратный
//из переданного числа если число положительное.
//В Main необходимо сделать так что бы пользователь мог вводить
//число бесконечное количество раз пока не введет 0.
//Main Должен обработать все варианты не правильного ввода,
//использовать Exception. В блоке finally нужно написать что программа завершена 

namespace HomeWork_09_06_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numb;

            try
            {
                do
                {
                    Console.WriteLine("Введите число");
                    numb = int.Parse(Console.ReadLine());
                    Console.WriteLine(EnterNumber(numb));
                } while (numb != 0);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Programm end");
            }

            
            

        }

        static double EnterNumber(double number) 
        {
            double sqrtNumber = 0;
            try
            {
                try
                {

                    if (number < 0)
                    {
                        throw new Exception("Число отрицательное");
                    }
                    else
                    {
                        sqrtNumber = Math.Sqrt(number);
                    }
                }
                catch
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
            return sqrtNumber;
            
        }
    }
}
