using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*4.Создайте функцию, которая принимает строку где каждое слово начинается с маленькой буквы. Функция должна возвращать строку, в которой все слова с большой буквы
	Вход: привет как дела
	Выход: Привет Как Дела*/
	

namespace HomeWork_06_04_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newString = "привет как дела";
            Console.WriteLine(ReturnString(newString)); 
        }

        static string ReturnString(string text)
        {
            string[] textArray = text.Split(' ');
            string[] newTextArray = new string[textArray.Length];
           
            for (int i = 0; i < textArray.Length; i++)
            {
               for (int j = 0; j < textArray[i].Length; j++)
               {
                    if (textArray[i].Length > 0)
                    {
                        newTextArray[i] = char.ToUpper(textArray[i][0]) + textArray[i].Substring(1); // Я использовал textArray[i].Substring(1), чтобы добавить оставшуюся часть слова после преобразования первой буквы.
                    }
               }
            }

            return string.Join(" ", newTextArray );
        }
    }
}
