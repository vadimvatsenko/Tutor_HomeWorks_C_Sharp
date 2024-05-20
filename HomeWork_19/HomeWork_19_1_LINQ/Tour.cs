using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Tour // Тур/Локация
    {
        public string TourID { get; private set; }
        public string TourNumberRegID { get; private set; }
        public string LocationID { get; private set; }

        public Tour(Location location, TourRegistration tourRegistration) 
        {
            TourNumberRegID = tourRegistration.TourRegistrationNumberID;
            TourID = IDGenerator.GenerateStringID(4); // верно
            LocationID = location.LocationID;
        }

        /*public void Print()
        {
            Console.WriteLine($"NumberTour: {TourNumber }, \n" +
                $"TourID: {TourID}, \n" +
                $"LocationID: {LocationID}");
        }*/
    }
}

//DONE
