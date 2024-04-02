using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вводится двузначное целое число. Создайте метод ChangeDigits(),
// который принимает введенный аргумент по ссылке и изменяет его значение так,
// чтобы первая цифра нового числа была второй цифрой введенного числа и, наоборот,
// вторая цифра нового числа была первой цифрой введенного числа.
// Например, если ввести 45, то результирующее число будет равно 54. 

namespace HomeWork_06_07_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = 62;
            ChangeDigits(ref numb);
            Console.WriteLine(numb.ToString());
        }

        static void ChangeDigits(ref int n)
        {
            string value = n.ToString();
            string[] valueArray = new string[value.Length];

            string newString = string.Empty;

            for (int i = value.Length - 1; i >= 0; i--) 
            {
                newString += value[i];
            }

            n = int.Parse(newString);
        }
    }
}
