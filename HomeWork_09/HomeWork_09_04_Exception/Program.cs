using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Создайте делегат и закиньте в него значение null.
// Напишите программу, которая обрабатывает исключение когда делегат пустой.
// Добавьте еще блок finally который выводит сообщение о том, что программа завершена 

namespace HomeWork_09_04_Exception
{
    delegate void NullDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            NullDelegate nullDelegate = null;
            
            try
            {
                nullDelegate();
            }
            catch (NullReferenceException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
        }
    }
}
