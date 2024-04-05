using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17_1_Interfaces
{
    delegate void CallMethod();
    internal class Person : IFly, IProperty, ISwim, IRun
    {
        public void Activate(CallMethod method)
        {
            method?.Invoke();
        }

        public void Fly()
        {
            Console.WriteLine("I am Flying");
        }


        public void Run()
        {
            Console.WriteLine("I am Running");
        }

        public void Swim()
        {
            Console.WriteLine("I am Swiming");
        }
    }
}
