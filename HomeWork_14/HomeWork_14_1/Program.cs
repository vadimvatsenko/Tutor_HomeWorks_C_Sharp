using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Припустимо, у вас є ієрархія класів, що включає базовий клас Animal та похідні класи Dog та Cat.
// У базового класу є 2 віртуальні методи MakeSound і ActivityStatus, які виводять базові повідомлення.
// Dog і Cat повинні переорпеділювати ActivityStatus,
// але повинні приховувати реалізацію базового методу MakeSound.
// Покажіть в Мейні як працює ваше приховування та ваше перевизначення.

namespace HomeWork_14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Spike", Gender.Boy, Status.Walk);
            dog.MakeSound();
        }
    }
}
