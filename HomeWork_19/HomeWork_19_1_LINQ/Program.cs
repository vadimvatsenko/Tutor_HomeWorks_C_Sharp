using RestSharp;
using System;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace HomeWork_19_1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> usersList = new List<User>()
            {
                new User("Vadym", "Vatsenko", 0934223131),
                new User("Emily", "Johnson", 0945567788),
                new User("Michael", "Williams", 0923344556),
                new User("Jessica", "Smith", 0912233445),
                new User("Brandon", "Brown", 0976677889),
                new User("Sarah", "Miller", 0965544332),
                new User("Ryan", "Davis", 0956677889),
                new User("Amanda", "Wilson", 0947788990),
                new User("Christopher", "Taylor", 0936677885),
                new User("Ashley", "Martinez", 0985544332),
                new User("Alexander", "Smith", 0671234567),
                new User("Emily", "Johnson", 0509876543),
                new User("Daniel", "Brown", 0631112233),
                new User("Olivia", "Taylor", 0685554433),
                new User("Ethan", "Wilson", 0958765432),
            }; // список юзеров
            List<Salary> employeeSalariesList = new List<Salary>()
            {
                new Salary(usersList[0], new DateTime(2024, 5, 1, 9, 30, 00 ), 14900.00),
                new Salary(usersList[1], new DateTime(2024, 4, 1, 9, 40, 00 ), 20000.00),
                new Salary(usersList[2], new DateTime(2024, 4, 1, 9, 50, 00 ), 1500.00),
                new Salary(usersList[3], new DateTime(2024, 4, 1, 10, 00, 00 ), 50000.00),
                new Salary(usersList[4], new DateTime(2024, 5, 1, 10, 15, 00 ), 750.00),
                new Salary(usersList[5], new DateTime(2024, 5, 1, 10, 15, 00 ), 750.00),
                new Salary(usersList[6], new DateTime(2024, 2, 1, 10, 15, 00 ), 1750.00),
                new Salary(usersList[7], new DateTime(2024, 2, 1, 10, 15, 00 ), 1250.00),
                new Salary(usersList[8], new DateTime(2024, 5, 1, 10, 15, 00 ), 7450.00),
                new Salary(usersList[9], new DateTime(2024, 5, 1, 10, 15, 00 ), 650.00),
                new Salary(usersList[10], new DateTime(2024, 5, 1, 10, 15, 00 ), 1350.00),
                new Salary(usersList[11], new DateTime(2024, 1, 1, 10, 15, 00 ), 2750.00),
                new Salary(usersList[12], new DateTime(2024, 5, 1, 10, 15, 00 ), 3750.00),
                new Salary(usersList[13], new DateTime(2024, 5, 1, 10, 15, 00 ), 2250.00),
                new Salary(usersList[14], new DateTime(2024, 5, 1, 10, 15, 00 ), 1150.00),
            };
            List<Insurance> insurancesList = new List<Insurance>()
            {
                new Insurance(usersList[0], "SecureGuard Insurance", new DateTime(2025, 1, 20), 5000, new DateTime(2024, 1, 20)),
                new Insurance(usersList[1], "Liberty Mutual Assurance", new DateTime(2025, 1, 30), 4000, new DateTime(2024, 1, 30)),
                new Insurance(usersList[2], "Guardian Life Insurance", new DateTime(2025, 2, 20), 300, new DateTime(2024, 2, 20)),
                new Insurance(usersList[3], "SafeHarbor Insurance Services", new DateTime(2025, 3, 15), 500, new DateTime(2024, 3, 15)),
                new Insurance(usersList[4], "Shield Insurance Agency", new DateTime(2025, 1, 2), 5000, new DateTime(2024, 1, 2)),
                new Insurance(usersList[5], "Assurance Partners Inc.", new DateTime(2025, 3, 31), 5000, new DateTime(2024, 3, 31)),
                new Insurance(usersList[6], "TrustPoint Insurance Group", new DateTime(2025, 4, 7), 5000, new DateTime(2024, 4, 7)),
                new Insurance(usersList[7], "Paramount Assurance Solutions", new DateTime(2025, 1, 5), 5000, new DateTime(2024, 1, 5)),
                new Insurance(usersList[8], "Integrity Insurance Agency", new DateTime(2025, 5, 2), 5000, new DateTime(2024, 5, 2)),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2025, 4, 28), 5000, new DateTime(2024, 4, 28)),
                new Insurance(usersList[0], "SecureGuard Insurance", new DateTime(2025, 1, 20), 5000, new DateTime(2024, 1, 20)),
                new Insurance(usersList[1], "Liberty Mutual Assurance", new DateTime(2025, 1, 30), 4000, new DateTime(2024, 1, 30)),
                new Insurance(usersList[2], "Guardian Life Insurance", new DateTime(2025, 2, 20), 300, new DateTime(2024, 2, 20)),
                new Insurance(usersList[3], "SafeHarbor Insurance Services", new DateTime(2025, 3, 15), 500, new DateTime(2024, 3, 15)),
                new Insurance(usersList[4], "Shield Insurance Agency", new DateTime(2025, 1, 2), 5000, new DateTime(2024, 1, 2)),
                new Insurance(usersList[5], "Assurance Partners Inc.", new DateTime(2025, 3, 31), 5000, new DateTime(2024, 3, 31)),
                new Insurance(usersList[6], "TrustPoint Insurance Group", new DateTime(2025, 4, 7), 5000, new DateTime(2024, 4, 7)),
                new Insurance(usersList[7], "Paramount Assurance Solutions", new DateTime(2025, 1, 5), 5000, new DateTime(2024, 1, 5)),
                new Insurance(usersList[8], "Integrity Insurance Agency", new DateTime(2025, 5, 2), 5000, new DateTime(2024, 5, 2)),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2025, 4, 28), 5000, new DateTime(2024, 4, 28)),
                new Insurance(usersList[0], "SecureGuard Insurance", new DateTime(2025, 1, 20), 5000, new DateTime(2024, 1, 20)),
                new Insurance(usersList[1], "Liberty Mutual Assurance", new DateTime(2025, 1, 30), 4000, new DateTime(2024, 1, 30)),
                new Insurance(usersList[2], "Guardian Life Insurance", new DateTime(2025, 2, 20), 300, new DateTime(2024, 2, 20)),
                new Insurance(usersList[3], "SafeHarbor Insurance Services", new DateTime(2025, 3, 15), 500, new DateTime(2024, 3, 15)),
                new Insurance(usersList[4], "Shield Insurance Agency", new DateTime(2025, 1, 2), 5000, new DateTime(2024, 1, 2)),
                new Insurance(usersList[5], "Assurance Partners Inc.", new DateTime(2025, 3, 31), 5000, new DateTime(2024, 3, 31)),
                new Insurance(usersList[6], "TrustPoint Insurance Group", new DateTime(2025, 4, 7), 5000, new DateTime(2024, 4, 7)),
                new Insurance(usersList[7], "Paramount Assurance Solutions", new DateTime(2025, 1, 5), 5000, new DateTime(2024, 1, 5)),
                new Insurance(usersList[8], "Integrity Insurance Agency", new DateTime(2025, 5, 2), 5000, new DateTime(2024, 5, 2)),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2025, 4, 28), 5000, new DateTime(2024, 4, 28)),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2025, 4, 28), 5000, new DateTime(2024, 4, 28)),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2025, 4, 28), 5000, new DateTime(2024, 4, 28)),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2025, 4, 28), 5000, new DateTime(2024, 4, 28)),

            }; // список страховок
            List<Country> countryList = new List<Country>()
            {
                new Country("United Kingdom", true),
                new Country("Poland", false),
                new Country("Germany", true),
                new Country("France", false),
                new Country("Italy", false),
                new Country("Spain", true),
                new Country("Japan", true),
                new Country("Thailand", true),
                new Country("Australia", true),
                new Country("Canada", true),
                new Country("Brazil", true),
            }; // список стран
            List<Cities> cityList = new List<Cities>()
            {
                new Cities("London"),
                new Cities("Manchester"),
                new Cities("Edinburgh"),
                new Cities("Warsaw"),
                new Cities("Krakow"),
                new Cities("Wroclaw"),
                new Cities("Berlin"),
                new Cities("Hamburg"),
                new Cities("Munich"),
                new Cities("Paris"),
                new Cities("Marseille"),
                new Cities("Lyon"),
                new Cities("Rome"),
                new Cities("Milan"),
                new Cities("Venice"),
                new Cities("Madrid"),
                new Cities("Barcelona"),
                new Cities("Seville"),
                new Cities("Tokyo"),
                new Cities("Osaka"),
                new Cities("Kyoto"),
                new Cities("Bangkok"),
                new Cities("Phuket"),
                new Cities("Chiang Mai"),
                new Cities("Sydney"),
                new Cities("Melbourne"),
                new Cities("Brisbane"),
                new Cities("Toronto"),
                new Cities("Vancouver"),
                new Cities("Montreal"),
                new Cities("Sao Paulo"),
                new Cities("Rio de Janeiro"),
                new Cities("Salvador")
            }; // список городов
            List<Location> locationsList = FillLocations(countryList, cityList); // список локаций
            List<TourRegistration> tourRegistrationsList = new List<TourRegistration>()
            {
                new TourRegistration("Historical Treasures Tour", Transport.Bus, Transport.Car, "Explore Ancient Sites", new DateTime(2024, 4, 5), 500),
                new TourRegistration("Nature Explorer Expedition", Transport.Car, Transport.Car, "Discover Natural Wonders", new DateTime(2024, 6, 15), 1500),
                new TourRegistration("Cultural Immersion Journey", Transport.Ship, Transport.Taxy, "Experience Local Traditions", new DateTime(2024, 6, 11), 2500),
                new TourRegistration("Adventure Seeker's Quest", Transport.Airplane, Transport.Ship, "Thrilling Outdoor Adventures", new DateTime(2024, 6, 16), 500),
                new TourRegistration("Food and Wine Trail", Transport.Taxy, Transport.Ship, "Indulge in Gastronomy", new DateTime(2025, 6, 5), 300),
                new TourRegistration("City Lights Tour", Transport.Taxy, Transport.Airplane, "Urban Exploration Excursion", new DateTime(2024, 7, 5), 700),
                new TourRegistration("Island Paradise Escape", Transport.Ship, Transport.Ship, "Tropical Bliss Retreat", new DateTime(2024, 8, 12), 700),
                new TourRegistration("Wildlife Safari Adventure", Transport.Bus, Transport.Bus, "Encounter Exotic Animals", new DateTime(2024, 8, 9), 800),
                new TourRegistration("Heritage Trail Experience", Transport.Airplane, Transport.Taxy, "Dive into History", new DateTime(2024, 6, 30), 800),
                new TourRegistration("Historical Treasures Tour", Transport.Bus, Transport.Car, "Explore Ancient Sites", new DateTime(2024, 6, 5), 500),
                new TourRegistration("Nature Explorer Expedition", Transport.Car, Transport.Car, "Discover Natural Wonders", new DateTime(2024, 6, 15), 1500),
                new TourRegistration("Cultural Immersion Journey", Transport.Ship, Transport.Taxy, "Experience Local Traditions", new DateTime(2024, 6, 13), 2500),
                new TourRegistration("Adventure Seeker's Quest", Transport.Airplane, Transport.Ship, "Thrilling Outdoor Adventures", new DateTime(2024, 6, 16), 500),
                new TourRegistration("Food and Wine Trail", Transport.Taxy, Transport.Ship, "Indulge in Gastronomy", new DateTime(2025, 6, 5), 300),
                new TourRegistration("City Lights Tour", Transport.Taxy, Transport.Airplane, "Urban Exploration Excursion", new DateTime(2024, 7, 5), 700),
                new TourRegistration("Island Paradise Escape", Transport.Ship, Transport.Ship, "Tropical Bliss Retreat", new DateTime(2024, 8, 12), 700),
                new TourRegistration("Wildlife Safari Adventure", Transport.Bus, Transport.Bus, "Encounter Exotic Animals", new DateTime(2024, 8, 9), 800),
                new TourRegistration("Heritage Trail Experience", Transport.Airplane, Transport.Taxy, "Dive into History", new DateTime(2024, 6, 30), 800),
                new TourRegistration("Historical Treasures Tour", Transport.Bus, Transport.Car, "Explore Ancient Sites", new DateTime(2024, 3, 5), 500),
                new TourRegistration("Nature Explorer Expedition", Transport.Car, Transport.Car, "Discover Natural Wonders", new DateTime(2024, 6, 15), 1500),
                new TourRegistration("Cultural Immersion Journey", Transport.Ship, Transport.Taxy, "Experience Local Traditions", new DateTime(2024, 6, 15), 2500),
                new TourRegistration("Adventure Seeker's Quest", Transport.Airplane, Transport.Ship, "Thrilling Outdoor Adventures", new DateTime(2024, 6, 16), 500),
                new TourRegistration("Food and Wine Trail", Transport.Taxy, Transport.Ship, "Indulge in Gastronomy", new DateTime(2025, 6, 5), 300),
                new TourRegistration("City Lights Tour", Transport.Taxy, Transport.Airplane, "Urban Exploration Excursion", new DateTime(2024, 7, 12), 700),
                new TourRegistration("Island Paradise Escape", Transport.Ship, Transport.Ship, "Tropical Bliss Retreat", new DateTime(2024, 8, 12), 700),
                new TourRegistration("Wildlife Safari Adventure", Transport.Bus, Transport.Bus, "Encounter Exotic Animals", new DateTime(2024, 8, 9), 800),
                new TourRegistration("Heritage Trail Experience", Transport.Airplane, Transport.Taxy, "Dive into History", new DateTime(2024, 6, 30), 800),
                new TourRegistration("Historical Treasures Tour", Transport.Bus, Transport.Car, "Explore Ancient Sites", new DateTime(2024, 6, 5), 500),
                new TourRegistration("Nature Explorer Expedition", Transport.Car, Transport.Car, "Discover Natural Wonders", new DateTime(2024, 6, 15), 1500),
                new TourRegistration("Cultural Immersion Journey", Transport.Ship, Transport.Taxy, "Experience Local Traditions", new DateTime(2024, 6, 11), 2500),
                new TourRegistration("Adventure Seeker's Quest", Transport.Airplane, Transport.Ship, "Thrilling Outdoor Adventures", new DateTime(2024, 6, 16), 500),
                new TourRegistration("Food and Wine Trail", Transport.Taxy, Transport.Ship, "Indulge in Gastronomy", new DateTime(2025, 6, 5), 300),
                new TourRegistration("City Lights Tour", Transport.Taxy, Transport.Airplane, "Urban Exploration Excursion", new DateTime(2024, 7, 5), 700),
                
            }; // оформление тура
            List<Tour> toursList = FillTours(locationsList, tourRegistrationsList); // тур
            List<Review> reviewsList = new List<Review>()
            {
                new Review(usersList[0], toursList[3], "Good"),
                new Review(usersList[1], toursList[7], "Very Good"),
                new Review(usersList[2], toursList[20], "Bad"),
                new Review(usersList[3], toursList[16], "Very Bed"),
                new Review(usersList[4], toursList[11], "Excellent"),
                new Review(usersList[5], toursList[29], "Wonderfull"),
                new Review(usersList[6], toursList[13], "Not Bad"),
                new Review(usersList[7], toursList[7], "Amazing"),
                new Review(usersList[8], toursList[2], "So-So"),
                new Review(usersList[9], toursList[1], "Cool"),
            }; // отзыв
            List<Tickets> ticketsList = new List<Tickets>()
            {
                new Tickets(new DateTime(2024, 5, 20), insurancesList[0], new DateTime(2024, 4, 10)),
                new Tickets(new DateTime(2024, 5, 15), insurancesList[1], new DateTime(2024, 7, 01)),
                new Tickets(new DateTime(2024, 5, 12), insurancesList[2], new DateTime(2024, 8, 26)),
                new Tickets(new DateTime(2024, 5, 16), insurancesList[3], new DateTime(2024, 5, 30)),
                new Tickets(new DateTime(2024, 5, 5), insurancesList[4], new DateTime(2024, 4, 05)),
                new Tickets(new DateTime(2024, 5, 2), insurancesList[5], new DateTime(2024, 5, 16)),
                new Tickets(new DateTime(2024, 5, 17), insurancesList[6], new DateTime(2024, 5, 31)),
                new Tickets(new DateTime(2024, 5, 19), insurancesList[7], new DateTime(2024, 4, 07)),
                new Tickets(new DateTime(2024, 5, 11), insurancesList[8], new DateTime(2024, 5, 25)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[9], new DateTime(2024, 6, 13)),
                new Tickets(new DateTime(2024, 5, 20), insurancesList[10], new DateTime(2024, 4, 01)),
                new Tickets(new DateTime(2024, 5, 15), insurancesList[11], new DateTime(2024, 5, 29)),
                new Tickets(new DateTime(2024, 5, 12), insurancesList[12], new DateTime(2024, 5, 26)),
                new Tickets(new DateTime(2024, 5, 16), insurancesList[13], new DateTime(2024, 5, 30)),
                new Tickets(new DateTime(2024, 5, 5), insurancesList[14], new DateTime(2024, 4, 05)),
                new Tickets(new DateTime(2024, 5, 2), insurancesList[15], new DateTime(2024, 5, 16)),
                new Tickets(new DateTime(2024, 5, 17), insurancesList[16], new DateTime(2024, 5, 31)),
                new Tickets(new DateTime(2024, 5, 19), insurancesList[17], new DateTime(2024, 4, 07)),
                new Tickets(new DateTime(2024, 5, 11), insurancesList[18], new DateTime(2024, 5, 25)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[19], new DateTime(2024, 6, 13)),
                new Tickets(new DateTime(2024, 5, 20), insurancesList[20], new DateTime(2024, 4, 01)),
                new Tickets(new DateTime(2024, 5, 15), insurancesList[21], new DateTime(2024, 5, 29)),
                new Tickets(new DateTime(2024, 5, 12), insurancesList[22], new DateTime(2024, 5, 26)),
                new Tickets(new DateTime(2024, 5, 16), insurancesList[23], new DateTime(2024, 5, 30)),
                new Tickets(new DateTime(2024, 5, 5), insurancesList[24], new DateTime(2024, 4, 05)),
                new Tickets(new DateTime(2024, 5, 2), insurancesList[25], new DateTime(2024, 5, 16)),
                new Tickets(new DateTime(2024, 5, 17), insurancesList[26], new DateTime(2024, 5, 31)),
                new Tickets(new DateTime(2024, 5, 19), insurancesList[27], new DateTime(2024, 4, 07)),
                new Tickets(new DateTime(2024, 5, 11), insurancesList[28], new DateTime(2024, 5, 25)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[29], new DateTime(2024, 6, 13)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[30], new DateTime(2024, 6, 13)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[31], new DateTime(2024, 6, 13)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[32], new DateTime(2024, 9, 11)),
            }; // заявка на билет
            List<Contract> contractsList = new List<Contract>()
            {
                new Contract(tourRegistrationsList[0], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[1], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[2], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[3], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[4], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[5], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[6], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[7], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[8], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[9], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[10], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[11], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[12], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[13], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[14], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[15], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[16], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[17], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[18], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[19], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[20], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[21], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[22], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[23], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[24], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[25], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[26], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[27], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[28], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[29], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[30], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[31], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[32], new DateTime(2024, 5, 15), usersList[0], usersList[10], new DateTime(2024, 5, 3), 100, new DateTime(2024, 5, 13)),



                new Contract(tourRegistrationsList[5], new DateTime(2024, 5, 18), usersList[1], usersList[10], new DateTime(2024, 5, 4), 150, new DateTime(2024, 5, 15)),
                new Contract(tourRegistrationsList[5], new DateTime(2024, 5, 18), usersList[1], usersList[10], new DateTime(2024, 5, 4), 150, new DateTime(2024, 5, 15)),
                new Contract(tourRegistrationsList[11], new DateTime(2024, 5, 10), usersList[2], usersList[10], new DateTime(2024, 5, 7), 90, new DateTime(2024, 5, 8)),
                new Contract(tourRegistrationsList[11], new DateTime(2024, 5, 10), usersList[2], usersList[10], new DateTime(2024, 5, 7), 90, new DateTime(2024, 5, 8)),
                new Contract(tourRegistrationsList[15], new DateTime(2024, 5, 6), usersList[3], usersList[11], new DateTime(2024, 5, 3), 140, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[2], new DateTime(2024, 5, 5), usersList[4], usersList[12], new DateTime(2024, 5, 2), 200, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[2], new DateTime(2024, 5, 5), usersList[4], usersList[12], new DateTime(2024, 5, 2), 200, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[2], new DateTime(2024, 5, 5), usersList[4], usersList[12], new DateTime(2024, 5, 2), 200, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[2], new DateTime(2024, 5, 5), usersList[4], usersList[12], new DateTime(2024, 5, 2), 200, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[2], new DateTime(2024, 5, 5), usersList[4], usersList[12], new DateTime(2024, 5, 2), 200, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[6], new DateTime(2024, 5, 4), usersList[5], usersList[13], new DateTime(2024, 5, 1), 220, new DateTime(2024, 5, 3)),
                new Contract(tourRegistrationsList[25], new DateTime(2024, 5, 13), usersList[6], usersList[14], new DateTime(2024, 5, 11), 110, new DateTime(2024, 5, 13)),
                new Contract(tourRegistrationsList[30], new DateTime(2024, 5, 20), usersList[7], usersList[14], new DateTime(2024, 5, 12), 60, new DateTime(2024, 5, 17)),
                new Contract(tourRegistrationsList[30], new DateTime(2024, 5, 20), usersList[7], usersList[14], new DateTime(2024, 5, 12), 60, new DateTime(2024, 5, 17)),
                new Contract(tourRegistrationsList[30], new DateTime(2024, 5, 20), usersList[7], usersList[14], new DateTime(2024, 5, 12), 60, new DateTime(2024, 5, 17)),
                new Contract(tourRegistrationsList[12], new DateTime(2024, 5, 13), usersList[8], usersList[13], new DateTime(2024, 5, 9), 50, new DateTime(2024, 5, 10)),
                new Contract(tourRegistrationsList[19], new DateTime(2024, 5, 9), usersList[9], usersList[11], new DateTime(2024, 5, 5), 95, new DateTime(2024, 5, 7)),
                new Contract(tourRegistrationsList[19], new DateTime(2024, 5, 9), usersList[9], usersList[11], new DateTime(2024, 5, 5), 95, new DateTime(2024, 5, 7)),
                new Contract(tourRegistrationsList[19], new DateTime(2024, 5, 9), usersList[9], usersList[11], new DateTime(2024, 5, 5), 95, new DateTime(2024, 5, 7)),

                new Contract(tourRegistrationsList[0], new DateTime(2024, 5, 9), usersList[9], usersList[11], new DateTime(2024, 5, 5), 95, new DateTime(2024, 5, 7)),
            };

            //1. Получить перечень городов из массива типа Location, айди содержит 5 и названия городов должны начинаться с буквы M
            #region
            Console.WriteLine("HomeWork: 1");
            Console.WriteLine("-Операторы-");

            var sortCities = from l in locationsList
                             join c in cityList on l.CityID equals c.CitiID
                             where c.CitiID.Contains("5") && c.CitiName.StartsWith("M")
                             select c;

            foreach (var city in sortCities)
            {
                city.Print();
            }
            Console.WriteLine();
            var sortCities2 = locationsList.Join(cityList,
                              l => l.CityID,
                              c => c.CitiID,
                              (l, c) => new { Name = c.CitiName, ID = l.CityID }).
                              Where(x => x.ID.Contains("5") && x.Name.StartsWith("M"));

            Console.WriteLine("-Методы расширения-");
            foreach (var city in sortCities2)
            {
                Console.WriteLine($"{city.Name}, {city.ID}");
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //2. Получить ранжированный список пользователей с именем и фамилией, зарплата которых не больше 15000 и дата полученный больше чем 12.04.2024
            //3. Дополнить второе задание и получить список зарплат и увеличить каждую зарплату на 20% и вывести данные в формате Name Surname : Salary
            #region
            Console.WriteLine("HomeWork: 2,3");
            Console.WriteLine("-Операторы-");
            var sortEployees = from u in usersList
                               join s in employeeSalariesList on u.UserID equals s.EmployeeID
                               orderby u.SecondName
                               where s.EmployeeMoney < 15000 && s.dateTimeSalary > new DateTime(2024, 4, 12)
                               select new
                               {
                                   UName = u.FirstName,
                                   USecondName = u.SecondName,
                                   Salary = s.EmployeeMoney,
                                   Salary20 = Math.Round(s.EmployeeMoney * 1.2f, 0),
                                   Date = s.dateTimeSalary,
                               };
            
            foreach (var u in sortEployees)
            {
                Console.WriteLine($"Name: {u.UName}, SecondName: {u.USecondName}, \n" +
                    $"Salary: {u.Salary}$, \n" +
                    $"Salary + 20%: {u.Salary20}$, \n" +
                    $"Salary Date: {u.Date}");
                Console.WriteLine();
            }

            Console.WriteLine("-Методы расширения-");
            var sortEployees1 = usersList.Join(employeeSalariesList,
                                    u => u.UserID,
                                    e => e.EmployeeID,
                                    (u, e) => new { Name = u.FirstName, SecondName = u.SecondName, Sal = e.EmployeeMoney, Sal20 = e.EmployeeMoney * 1.2, Date = e.dateTimeSalary })
                                    .Where(e => e.Sal < 15000 && e.Date > new DateTime(2024, 4, 12));
            
            foreach (var s in sortEployees1)
            {
                Console.WriteLine($"Name: {s.Name}, SecondName: {s.SecondName}, \n" +
                    $"Salary: {s.Sal}$, \n" +
                    $"Salary + 20%: {s.Sal20}$, \n" +
                    $"Salary Date: {s.Date}");
                Console.WriteLine();
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //4. Получить перечень туров, ранжированных по количеству посещаемых стран. // 2ва 
            #region
            Console.WriteLine("HomeWork: 4");
            Console.WriteLine("-Операторы-");

            var tourLocationList = (from t in tourRegistrationsList // оформление тура
                                    join tl in toursList on t.TourRegistrationNumberID equals tl.TourNumberRegID // тур-локация
                                    join l in locationsList on tl.LocationID equals l.LocationID
                                    group l by t.TourRegistrationName into g

                                    select new
                                    {
                                        KeyN = g.Key,
                                        Name = g,
                                        Count = g.Select(p => p.CountryID).Count(),
                                    }).OrderByDescending(d => d.Count);

            foreach (var s in tourLocationList)
            {
                Console.WriteLine(s.KeyN + ": " + s.Count);
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //5. Получить ранжированный список стран по посещаемости(количеству договоров)
            #region
            Console.WriteLine("HomeWork: 5");
            Console.WriteLine("-Операторы-");
            var sortCountries1 = (from c in contractsList
                                 join tr in tourRegistrationsList on c.TourRegNumberID equals tr.TourRegistrationNumberID
                                 join t in toursList on tr.TourRegistrationNumberID equals t.TourNumberRegID
                                 join l in locationsList on t.LocationID equals l.LocationID
                                 join con in countryList on l.CountryID equals con.CountryId
                                 group c by con.CountryName into g                                 
                                 select new
                                 {
                                     Name = g.Key,
                                     Count = g.Count()
                                 }).OrderByDescending(d => d.Count);


            foreach (var s in sortCountries1)
            {
                Console.WriteLine(s.Name + " " + s.Count);
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //6. Получить список пользователей, побывавших абсолютно во всех странах 
            #region
            Console.WriteLine("HomeWork: 6");
            Console.WriteLine("-Операторы-");
            var sortUsers = (from u in usersList
                            join c in contractsList on u.UserID equals c.UserID
                            join t in toursList on c.TourRegNumberID equals t.TourNumberRegID
                            join l in locationsList on t.LocationID equals l.LocationID
                            join con in countryList on l.CountryID equals con.CountryId
                            select new
                            {
                                Country = con.CountryName,
                                Name = ($"{u.FirstName} {u.SecondName}"),

                            });
                             

            foreach (var s in sortUsers)
            {
                Console.WriteLine(s.Name + " " + s.Country);
                
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //7. Посчитать доход от конкретного тура (на ваше усмотрение) по всем заказавшим его клиентам
            #region
            Console.WriteLine("HomeWork: 7");
            Console.WriteLine("-Операторы-");
            var tourIncome = from u in usersList
                             join c in contractsList on u.UserID equals c.UserID
                             join t in tourRegistrationsList on c.TourRegNumberID equals t.TourRegistrationNumberID
                             where t.TourRegistrationName == "City Lights Tour"
                             
                             group t by t.TourRegistrationName  into g // можно записать в g целый новый объект
                             select new
                             {
                                 //Name = $"{g.Key.FirstName} {g.Key.SecondName}",
                                 //Tour = g.Key.TourRegistrationName,
                                 Name = g.Key,
                                 TotalPrice = g.Sum(x => x.TourRegistrationPrice),
                             };

            foreach (var s in tourIncome)
            {
                Console.WriteLine($"{s.Name} - {s.TotalPrice}");                
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //8. Получить список клиентов, отправляющихся в поездку в период от 01.04.2024 до 07.04.2024
            #region
            Console.WriteLine("HomeWork: 8");
            Console.WriteLine("-Операторы-");
            var userVication = from u in usersList
                               join i in insurancesList on u.UserID equals i.UserID
                               join tl in ticketsList on i.InsuranceNumberID equals tl.NubmerInsuranceID
                               where tl.OutDate >= new DateTime(2024, 4, 01) && tl.OutDate <= new DateTime(2024, 4, 07)
                               group u by new { u.FirstName, u.SecondName } into g
                               select new
                               {
                                   Name = $"{g.Key.FirstName} {g.Key.SecondName}"
                               };

            foreach (var s in userVication)
            {
                Console.WriteLine($"user: {s.Name}");
            }
            Console.WriteLine("-Методы расширения-");

            var userVication1 = usersList.Join(insurancesList,
                u => u.UserID,
                i => i.UserID,
                (u, i) => new { u, i }
                ).Join(ticketsList,
                ui => ui.i.InsuranceNumberID,
                tl => tl.NubmerInsuranceID,
                (ui, tl) => new { ui.u, ui.i, tl }).Where(x => x.tl.OutDate >= new DateTime(2024, 4, 01) && x.tl.OutDate <= new DateTime(2024, 4, 07))
                .Select(x => new {x.u.FirstName, x.u.SecondName })
                .Distinct();

            foreach (var s in userVication1)
            {
              
                    Console.WriteLine($"name {s.FirstName} {s.SecondName}");
                
            }

            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion

            //9. Для конкретного пользователя (на ваше усмотрение) получить список стан, городов, вида транспорта и страховой компании с указанием что есть что
            #region
            Console.WriteLine("HomeWork: 9");
            Console.WriteLine("-Операторы-");
            var userInfo = (from u in usersList
                            join c in contractsList on u.UserID equals c.UserID
                            join i in insurancesList on u.UserID equals i.UserID
                            join tr in tourRegistrationsList on c.TourRegNumberID equals tr.TourRegistrationNumberID
                            join t in toursList on tr.TourRegistrationNumberID equals t.TourNumberRegID
                            join l in locationsList on t.LocationID equals l.LocationID
                            join ci in cityList on l.CityID equals ci.CitiID
                            join co in countryList on l.CountryID equals co.CountryId
                            where u.SecondName == "Williams"
                            group new { co, ci, i, tr } by new { u.FirstName, u.SecondName } into g
                            select new
                            {
                                Name = $"{g.Key.FirstName} {g.Key.SecondName}",
                                Country = g.Select(x => x.co.CountryName),
                                City = g.Select(x => x.ci.CitiName),
                                Transport = g.Select(x => x.tr.TransportForArrival),
                                Insurance = g.Select(x => x.i.CompanyName),

                            });

            // Как сгруппировать??

            foreach (var s in userInfo)
            {
                //Console.WriteLine($"Name: {s.Name}, Country: {s.Country}, City: {s.City}, Transport: {s.Transport}, Insurance: {s.Insurance} ");
                Console.WriteLine(s.Name);
                foreach (var c in s.Country)
                {
                    Console.WriteLine(c);
                }
                foreach (var cit in s.City)
                {
                    Console.WriteLine(cit);
                }
                foreach (var ins in s.Insurance)
                {
                    Console.WriteLine(ins);
                }
            }
            Console.WriteLine("-Методы расширения-");
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            //10.Получить список всех туров, продолжительность которых равна менее чем 60 дней и снизить их стоимость на процент равный продолжительности
            #region
            Console.WriteLine("HomeWork: 10");
            Console.WriteLine();
            var tourDuration = from tr in tourRegistrationsList
                               join c in contractsList on tr.TourRegistrationNumberID equals c.TourRegNumberID
                               join u in usersList on c.UserID equals u.UserID
                               join i in insurancesList on u.UserID equals i.UserID
                               join tic in ticketsList on i.InsuranceNumberID equals tic.NubmerInsuranceID
                               where (double)(tic.OutDate - tr.ValidyTour).TotalDays > 60f
                               let percent = (double)(tic.OutDate - tr.ValidyTour).TotalDays / 100f
                               select new
                               {
                                   Name = tr.TourRegistrationName,
                                   StandartCost = tr.TourRegistrationPrice,
                                   DiscountCost = tr.TourRegistrationPrice - (tr.TourRegistrationPrice * percent),
                                   ValidyDate = tr.ValidyTour,
                                   Out = tic.OutDate,
                                   Percent = percent
                               };
            foreach (var s in tourDuration)
            {
                Console.WriteLine($"TourName: {s.Name}, StandartCost: {s.StandartCost}$, DiscountCost: {s.DiscountCost}$, PercentDiscount: {(s.Percent * 100f).ToString() + " % "}");
            }
            #endregion
            // 11. Получить Список стран - городов
            #region
            Console.WriteLine("HomeWork: 11");
            Console.WriteLine();
            var sortCountriesAndCities = from c in cityList
                                         join l in locationsList on c.CitiID equals l.CityID
                                         join con in countryList on l.CountryID equals con.CountryId
                                         group c by con.CountryName into g
                                         select new
                                         {
                                             ConName = g.Key,
                                             Cityis = g.Select(x => x.CitiName).ToList()
                                         };
                                         

            foreach(var loc in sortCountriesAndCities) 
            {
                Console.WriteLine(loc.ConName);
                foreach (var i in loc.Cityis)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
            // 12 Список сотрудников и их ЗП
            #region
            var sortUserSalary = from u in usersList
                                 join s in employeeSalariesList on u.UserID equals s.EmployeeID
                                 where s.EmployeeMoney > 10000
                                 orderby s.EmployeeMoney
                                 select new
                                 {
                                     Name = u.FirstName,
                                     SecondName = u.SecondName,
                                     Salary = s.EmployeeMoney,
                                 };

            foreach(var s in sortUserSalary)
            {
                Console.WriteLine(s.Name + " " + s.SecondName + " " + s.Salary);                
            }
            Console.WriteLine("==========");
            Console.WriteLine();
            #endregion
        }
        static List<Location> FillLocations(List<Country> countryList, List<Cities> cityList)
        {
            List<Location> filledLocation = new List<Location>();
            for (int i = 0; i < countryList.Count; i++) // запись всех локаций
            {

                int start = 3 * i;
                int step = start + 3;

                for (int j = start; j < step; j++)
                    filledLocation.Add(new Location(countryList[i], cityList[j]));
            }

            return filledLocation;
        }
        static List<Tour> FillTours(List<Location> location, List<TourRegistration> tourRegistrations)
        {
            List<Tour> newTourList = new List<Tour>();
            for (int i = 0; i < location.Count; i++)
            {
                newTourList.Add(new Tour(location[i], tourRegistrations[i]));
            }

            return newTourList;
        }
    }
}

    





