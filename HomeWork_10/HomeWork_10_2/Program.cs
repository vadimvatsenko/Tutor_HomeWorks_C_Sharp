using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Сделать первое задание с использованием конструктора.
// Реализуйте 3 конструктора, первый принимает только имя,
// второй имя и возраст, третий имя возраст и тип.
// Создать для каждого поля значения по умолчанию.
// Также создайте 3 объекта и покажите информацию о каждом из них. 

namespace HomeWork_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.Print();

            Animal Cat = new Animal();
            Cat.Print();

            Animal Bird = new Animal();
            Bird.Print();

            Console.WriteLine();

            Animal Dog2 = new Animal("Spike");
            Dog2.Print();

            Console.WriteLine();

            Animal Dog3 = new Animal("Bob", 11);
            Dog3.Print();

            Console.WriteLine();

            Animal Dog4 = new Animal("Bim", 6, AnimalType.Dog);
            Dog4.Print();
        }
    }
}
