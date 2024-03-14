using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14_1
{
    public class Dog : Animal
    {
        public Dog(string name, Gender gender, Status status) : base(name, gender, status)
        {
        }

        private protected new string Name
        {
            get => $"Dog name {base.Name}";
            set => base.Name = value;
        }

        public override void ActivityStatus()
        {
            AnimalStatus = Status.Eat;
        }

        public new void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Woof");
        }


    }
}
