using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_1_Inheritance
{
    internal class Motobike : Vehicle
    {
        public string TypeOfByke { get; private set; }
        public Motobike(string name, string brand, float year, float price, string typeOfByke) : base(name, brand, year, price)
        {
            TypeOfByke = typeOfByke;
        }

        public void Print()
        {
            Console.WriteLine($"name = {Name}, brand = {Brand}, year = {Year}, price = {Price}, typeOfBike = {TypeOfByke} ");
        }
    }
}
