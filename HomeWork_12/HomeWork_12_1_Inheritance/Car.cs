using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_1_Inheritance
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; private set; }
        public Car(string name, string brand, float year, float price, int numberOfDoors) : base(name) // 2
        {
            NumberOfDoors = numberOfDoors; //8 - кто вызвал
        }

        public void Print()
        {
            base.Print();
            //Console.WriteLine($"name = {Name}, brand = {Brand}, year = {Year}, price = {Price}, numberOrDoors = {NumberOfDoors} ");
        }
    }
}
