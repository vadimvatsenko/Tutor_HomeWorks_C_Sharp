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

        private protected new readonly static int minAge = 2; // переопределение статической переменной
        private protected new const string type = "Human"; // переопределение const

        private protected new string Name
        {
            get => $"Dog name {base.Name}";
            set => base.Name = value;
        }

        public override void ActivityStatus() // override - нужно компилироваться, потому он работает медленней чем new
        {
            AnimalStatus = Status.Eat;
            Console.WriteLine("");
        }

        public new void MakeSound() // new вызывается сразу метод, без компиляции и перехода в базовый класс
        {
            //base.MakeSound();
            Console.WriteLine($"{Name} say Woof");
            Console.WriteLine(minAge);
            Console.WriteLine(type);
        }


    }
}
