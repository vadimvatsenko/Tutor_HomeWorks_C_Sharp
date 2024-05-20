using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Review
    {
        public string ReviewID { get; private set; }
        public string TourID { get; private set; }
        public string UserID { get; private set; }
        public string ReviewDesrc { get; private set; }

        public Review(User user, Tour tour, string reviewDesrc)
        {
            ReviewID = IDGenerator.GenerateStringID(6);
            UserID = user.UserID;
            TourID = tour.TourID;
            ReviewDesrc = reviewDesrc;
        }

        public void Print()
        {
            Console.WriteLine($"ReviewID: {ReviewID}, \n" +
                $"UserID: {UserID}, \n" +
                $"TourID: {TourID}, \n" +
                $"ReviewDescr: {ReviewDesrc}");
        }
    }
}

// DONE
