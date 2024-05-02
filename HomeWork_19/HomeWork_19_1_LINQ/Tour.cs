using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Tour
    {
        public static int NextNumber = 1;
        public int TourNumber { get; private set; } = 0;
        public string TourID { get; private set; }
        public string LocationID { get; private set; }

        public Tour(Location location) 
        {
            TourNumber = NextNumber++;
            TourID = IDGenerator.GenerateID(4);
            LocationID = location.LocationID;
        }

        public void Print()
        {
            Console.WriteLine($"NumberTour: {TourNumber }, \n" +
                $"TourID: {TourID}, \n" +
                $"LocationID: {LocationID}");
        }

    }
}
