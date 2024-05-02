using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 2.Конвертация строки в число:
// Попросите пользователя ввести строку, которую вы затем попытаетесь преобразовать в число.
// Обработайте исключение, которое может возникнуть при некорректном вводе.

namespace HomeWork_09_02_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enterNumb1 = string.Empty;
            string enterNumb2 = string.Empty;


            Console.WriteLine("Enter 1st Number");
            enterNumb1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd Number");
            enterNumb2 = Console.ReadLine();

            CheckNumber(enterNumb1, out int numberFirst);
            CheckNumber(enterNumb2, out int numberSecond);

            double result = 0;

            try
            {
                result = numberFirst / numberSecond;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Programm end");
            }
        }

        static void CheckNumber(string str, out int number)
        {

            if (int.TryParse(str, out number))
            {
                Console.WriteLine($"Correct numb = {number}");
            }
            else
            {
                Console.WriteLine($"Incorrect numb = {number}");
            }
        }
    }
}
