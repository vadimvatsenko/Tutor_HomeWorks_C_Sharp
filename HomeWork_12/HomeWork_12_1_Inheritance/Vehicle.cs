using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_1_Inheritance
{
    internal class Vehicle
    {
        public string Name { get; private protected set; }
        public string Brand { get; private protected set; }
        public float Year { get; private protected set; }
        public float Price { get; private protected set; }

        public Vehicle(string srt) : this(srt, 5) // 3
        {
            // 7
        }

        public Vehicle(string str, int numb) // 4
        {
            Name = str; //5
            Year = numb; // 6
        }
        public Vehicle(string name, string brand, float year, float price)
        {
            Name = name;
            Brand = brand;
            Year = year;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}, {Brand}, {Year}, {Price}");
        }


    }
}
