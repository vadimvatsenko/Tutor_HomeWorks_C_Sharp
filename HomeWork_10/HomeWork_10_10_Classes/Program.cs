using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Создайте класс "TemperatureConverter" в C#, который имеет два открытых свойства: Celsius и Fahrenheit
//и соответствующие им закрытые поля, представляющих температуру в градусах Цельсия и Фаренгейта соответственно.
//Используйте свойства get и set, чтобы обеспечить корректное взаимодействие между этими двумя единицами измерения.
//Добавьте методы ConvertToFahrenheit и ConvertToCelsius, которые позволяют конвертировать температуру из одной шкалы в другую.
//При этом обеспечьте проверку корректности ввода данных, чтобы температура не могла быть ниже значения -100.
//Создайте 2 объекта "TemperatureConverter", установите значения для закрытых полей через свойства и покажи как работают ваши методы. 

namespace HomeWork_10_10_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter celsius1 = new TemperatureConverter() { Celsius = -100 };
            TemperatureConverter fahrenheit1 = new TemperatureConverter() { Fahrenheit = -100 };
            Console.WriteLine(celsius1.Celsius);
            Console.WriteLine(fahrenheit1.Fahrenheit);
            Console.WriteLine("=======");

            TemperatureConverter celsius2 = new TemperatureConverter() { Celsius = 50 };
            TemperatureConverter fahrenheit2 = new TemperatureConverter() { Fahrenheit = 10 };

            //Console.WriteLine(fahrenheit2.ConvertToFahrenheit());
            Console.WriteLine(celsius2.Celsius);
            Console.WriteLine(celsius2.ConvertToFahrenheit());
        }
    }
}
