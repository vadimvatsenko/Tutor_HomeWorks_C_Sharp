using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Классы создаются в отдельных файлах. Создайте класс с названием Animal.
// Создайте в том же файле перечисление с вариантами bird cat dog undefined.
// Класс должен иметь поле int которое будет хранить возраст, поле с именем животного и тип животного.
// Поля сделать публичными.  Реализуйте метод Print, который выводит информацию о каждом из них.
// Создайте 3 объекта и заполните значениями все поля каждого объекта.
// Покажите что хранится в каждом объекте с помощью Print. 

namespace HomeWork_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog._animalType = AnimalType.Dog;
            Dog._name = "Doggy";
            Dog._age = 5;

            Dog.Print();

            Animal Cat = new Animal();
            Cat._animalType = AnimalType.Cat;
            Cat._name = "Kitty";
            Cat._age = 3;

            Cat.Print();

            Animal Bird = new Animal();
            Bird._animalType = AnimalType.Bird;
            Bird._name = "Callibri";
            Bird._age = 1;

            Bird.Print();
        }
    }
}
