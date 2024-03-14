using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Допустим, у вас есть класс Калькулятор, который содержит методы для выполнения различных математических операций.
// Задача состоит в том, чтобы перегрузить метод Calculate для поддержки разных типов данных и операций.
// Calculate должен принимать два типа данных int суммировать их и возвращать int.
// Следующий метод должен принимать 2 типа double находить разницу этих двух значения и возвращать абсолютную величину  double.
// Последний метод должен принимать 2 типа string и возвращать конкатенацию двух входных параметров. 

namespace HomeWork_10_11_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Calculate(20, 40));
            Console.WriteLine(calculator.Calculate(4.69, 70.48));
            Console.WriteLine(Math.Round(calculator.Calculate(90.60, 70.48)));
            Console.WriteLine(calculator.Calculate("Hello", "World"));
        }
    }
}
