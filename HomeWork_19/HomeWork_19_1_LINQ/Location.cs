using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Location // Локация
    {
        public string LocationID { get; private set; }
        public string CountryID { get; private set; }
        public string CityID { get; private set; }

        public Location(Country country, Cities city)
        {
            LocationID = IDGenerator.GenerateStringID(7);
            CountryID = country.CountryId;
            CityID = city.CitiID;
        }

        public void Print()
        {
            Console.WriteLine($"CountryID = {CountryID}, \n" +
                $"CityID = {CityID}");
        }
    }
}

//DONE
