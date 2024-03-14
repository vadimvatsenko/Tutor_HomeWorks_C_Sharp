using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14_1
{
    public class Cat: Animal
    {
        public Cat(string name, Gender gender, Status status) : base(name, gender, status)
        {
        }

        public new void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Cat say meow");
        }

       
    }
}
