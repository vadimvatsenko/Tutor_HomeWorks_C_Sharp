using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
   
    public class Country
    {
        public string CountryId { get; private set; }
        public string CountryName { get; private set; }
        public bool CountryVisa { get; private set; }

        public Country(string name, bool visa)
        {
            CountryId = IDGenerator.GenerateID(3);
            CountryName = name;
            CountryVisa = visa;
        }

        public void Print()
        {
            Console.WriteLine($"CountryID = {CountryId}, \n" +
                $"CountryName = {CountryName}, \n" +
                $"CountryVisa = {CountryVisa}");
        }
    }
}
