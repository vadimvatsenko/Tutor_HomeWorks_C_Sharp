using RestSharp;
using System;
using System.Diagnostics;

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
                new User("Ashley", "Martinez", 0985544332)
            }; // список юзеров
            List<Employee> employeesList = new List<Employee>()
            {
                new Employee("Alexander", "Smith"),
                new Employee("Emily", "Johnson"),
                new Employee("Daniel", "Brown"),
                new Employee("Olivia", "Taylor"),
                new Employee("Ethan", "Wilson"),

            }; // список сотрудников
            List<EmployeeSalary> employeeSalariesList = new List<EmployeeSalary>()
            {
                new EmployeeSalary(employeesList[0], new DateTime(2024, 5, 1, 9, 30, 00 ), 1000.00),
                new EmployeeSalary(employeesList[1], new DateTime(2024, 5, 1, 9, 40, 00 ), 1100.00),
                new EmployeeSalary(employeesList[2], new DateTime(2024, 5, 1, 9, 50, 00 ), 1500.00),
                new EmployeeSalary(employeesList[3], new DateTime(2024, 5, 1, 10, 00, 00 ), 900.00),
                new EmployeeSalary(employeesList[4], new DateTime(2024, 5, 1, 10, 15, 00 ), 750.00),
            };
            List<Insurance> insurancesList = new List<Insurance>()
            {
                new Insurance(usersList[0], "SecureGuard Insurance", new DateTime(2024, 1, 20), 5000),
                new Insurance(usersList[1], "Liberty Mutual Assurance", new DateTime(2024, 1, 30), 4000),
                new Insurance(usersList[2], "Guardian Life Insurance", new DateTime(2024, 2, 20), 300),
                new Insurance(usersList[3], "SafeHarbor Insurance Services", new DateTime(2024, 3, 15), 500),
                new Insurance(usersList[4], "Shield Insurance Agency", new DateTime(2024, 1, 2), 5000),
                new Insurance(usersList[5], "Assurance Partners Inc.", new DateTime(2024, 3, 31), 5000),
                new Insurance(usersList[6], "TrustPoint Insurance Group", new DateTime(2024, 4, 7), 5000),
                new Insurance(usersList[7], "Paramount Assurance Solutions", new DateTime(2024, 1, 5), 5000),
                new Insurance(usersList[8], "Integrity Insurance Agency", new DateTime(2024, 5, 2), 5000),
                new Insurance(usersList[9], "PrimeCare Insurance Services", new DateTime(2024, 4, 28), 5000),
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
            List<Tour> toursList = FillTours(locationsList);
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
            };
            List<Tickets> ticketsList = new List<Tickets>()
            {
                new Tickets(new DateTime(2024, 5, 20), insurancesList[3], new DateTime(2024, 6, 5)),
                new Tickets(new DateTime(2024, 5, 15), insurancesList[1], new DateTime(2024, 5, 29)),
                new Tickets(new DateTime(2024, 5, 12), insurancesList[7], new DateTime(2024, 5, 26)),
                new Tickets(new DateTime(2024, 5, 16), insurancesList[4], new DateTime(2024, 5, 30)),
                new Tickets(new DateTime(2024, 5, 5), insurancesList[2], new DateTime(2024, 5, 21)),
                new Tickets(new DateTime(2024, 5, 2), insurancesList[0], new DateTime(2024, 5, 16)),
                new Tickets(new DateTime(2024, 5, 17), insurancesList[8], new DateTime(2024, 5, 31)),
                new Tickets(new DateTime(2024, 5, 19), insurancesList[9], new DateTime(2024, 5, 2)),
                new Tickets(new DateTime(2024, 5, 11), insurancesList[5], new DateTime(2024, 5, 25)),
                new Tickets(new DateTime(2024, 5, 31), insurancesList[6], new DateTime(2024, 6, 13)),
            };

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
        static List<Tour> FillTours(List<Location> location)
        {
            List<Tour> newTourList = new List<Tour>();
            for(int i = 0; i < location.Count; i++)
            {
                newTourList.Add(new Tour(location[i]));
            }
            return newTourList;
        }
    }
}


