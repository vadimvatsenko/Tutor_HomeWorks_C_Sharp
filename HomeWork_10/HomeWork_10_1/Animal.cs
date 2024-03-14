using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_1
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
        public AnimalType _animalType;

        public void Print()
        {
            Console.WriteLine($"Animal {_animalType}, name {_name}, age {_age}, ");
        }
    }
}
