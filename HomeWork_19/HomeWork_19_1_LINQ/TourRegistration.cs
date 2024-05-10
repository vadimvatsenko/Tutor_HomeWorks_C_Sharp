using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public enum Transport
    {
        Taxy,
        Car,
        Bus,
        Airplane,
        Train,
        Ship
    }
    public class TourRegistration
    {
        public Transport TransportForArrival { get; private set; } // вид транспорта для прибытия
        public Transport TransportForExcursions { get; private set; } // вид транспорта для экскурсий 
        public DateTime ValidyTour { get; private set; } // период действия тура
        public int TourRegistrationNumberID { get; private set; } // номер тура ID
        public string TourRegistrationName { get; private set; } // название тура
        public string TourRegistrationDescr { get; private set; } // описание тура
        public double TourRegistrationPrice { get; private set; } // цена тура

        public TourRegistration( 
                                string tourRegistrationName, 
                                Transport transportForArrival, 
                                Transport transportForExcursions, 
                                string tourRegistrationDescr, 
                                DateTime validyTour, 
                                double tourRegistrationPrice)
        {
            TourRegistrationNumberID = IDGenerator.GenerateNumberID(7);
            TransportForArrival = transportForArrival;
            TransportForExcursions = transportForExcursions;
            ValidyTour = validyTour;
            TourRegistrationName = tourRegistrationName;
            TourRegistrationDescr = tourRegistrationDescr;
            TourRegistrationPrice = tourRegistrationPrice;
        }

        public void Print()
        {
            Console.WriteLine($"TourRegistrationNumberID: {TourRegistrationNumberID}, \n" +
                $"TourRegistrationName: {TourRegistrationName}, \n" +
                $"TransportForExcursions: {TransportForExcursions}, \n" +
                $"TransportForArrival: {TransportForArrival}, \n" +
                $"ValidyTour: {ValidyTour}, \n" +
                $"TourRegistrationDescr: {TourRegistrationDescr}, \n" +
                $"TourRegistrationPrice: {TourRegistrationPrice}");
        }
    }
}

// DONE
