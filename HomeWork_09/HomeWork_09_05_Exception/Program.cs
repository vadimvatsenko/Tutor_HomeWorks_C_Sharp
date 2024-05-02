using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Пускай пользователь вводит число – свой возраст.
// Создайте свое исключение с помощью throw, при ввода числа меньше 18.
// Если пользователь введет возраст больше 18, то выведите сообщение,
// о том что пользователь взрослый, в ином случае – исключение что он несовершеннолетний  

namespace HomeWork_09_05_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter your age");

                    string age = Console.ReadLine();

                    int.TryParse(age, out int ageNumb);

                    if (ageNumb < 18)
                    {
                        throw new Exception("Несовершеннолетний");
                    }
                    else
                    {
                        Console.WriteLine("Совершеннолетний");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
