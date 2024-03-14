using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_2
{
    public enum AnimalType
    {
        Bird,
        Cat,
        Dog,
        Undefined,
    }

    public class Animal
    {
        public int _age;
        public string _name;
        public AnimalType _animalType = AnimalType.Undefined; // по умолчанию

        public Animal()
        {
            this._age = 0;
            this._name = "NoName";
            this._animalType = AnimalType.Undefined;
        }

        public Animal(string name)
        {
            this._name = name;
        }

        public Animal(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public Animal(string name, int age, AnimalType animalType)
        {
            this._name = name;
            this._age = age;
            this._animalType = animalType;
        }

        public void Print()
        {
            Console.WriteLine($"Animal {_animalType}, name {_name}, age {_age}, ");
        }
    }
}
