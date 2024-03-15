using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Припустимо, у вас є ієрархія класів, що включає базовий клас Animal та похідні класи Dog та Cat.
// У базового класу є 2 віртуальні методи MakeSound і ActivityStatus, які виводять базові повідомлення.
// Dog і Cat повинні переорпеділювати ActivityStatus, але повинні приховувати реалізацію базового методу MakeSound.
// Покажіть в Мейні як працює ваше приховування та ваше перевизначення.

namespace HomeWork_14_1
{
    public enum Status
    {
        Sleep,
        Eat,
        Walk,
    }

    public enum Gender
    {
        Boy,
        Girl
    }
    public class Animal
    {
        private protected string Name{ get; set;}
        private protected Gender Gender { get; set;}
        private protected Status AnimalStatus {  get; set; }

        private protected readonly static int minAge = 1;
        private protected const string type = "Animal";

        public Animal(string name, Gender gender, Status status)
        { 
            Name = name;
            Gender = gender;
            AnimalStatus = status;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal say");
        }

        public virtual void ActivityStatus()
        {
            Console.WriteLine($"Animal is {Status.Sleep}");
        }
    }
}
