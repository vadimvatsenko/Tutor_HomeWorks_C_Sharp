using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Animal(string name, Gender gender, Status status)
        { 
            Name = name;
            Gender = gender;
            AnimalStatus = status;
        }

        private protected virtual void MakeSound()
        {
            Console.WriteLine("Animal say");
        }

        private protected virtual void ActivityStatus()
        {
            Console.WriteLine($"Animal is {Status.Sleep}");
        }
    }
}
