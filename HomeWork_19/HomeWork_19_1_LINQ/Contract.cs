using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Contract // Договор
    {
        public int TourNumberID { get; private set; } // номер тура
        public DateTime ContractPaymentDeadLine { get; private set; } // Срок Оплаты
        public int UserID { get; private set; } // Id клиента
        public int ContractNumberID { get; private set; } // номер договора
        public int EmployeeID { get; private set; } // id сотрудника
        public DateTime ContractDate { get; private set; } // дата заключения контракта
        public double ContractAmount { get; private set; } // сумма контракта
        public DateTime ContractDatePayment {  get; private set; } // дата платежа

        public Contract(Tour tour, DateTime contractPaymentDeadLine, User client, User employee, DateTime contractDate, double contractAmount, DateTime contractDatePayment)
        {
            TourNumberID = tour.TourID;
            ContractPaymentDeadLine = contractPaymentDeadLine;
            UserID = client.UserID;
            ContractNumberID = IDGenerator.GenerateNumberID(5);
            EmployeeID = employee.UserID;
            ContractDate = contractDate;
            ContractAmount = contractAmount;
            ContractDatePayment = contractDatePayment;
        }

        public void Print()
        {
            Console.WriteLine($"TourNumberID: {TourNumberID}, \n" +
                $"ContractPaymentDeadLine: {ContractPaymentDeadLine}, \n" +
                $"UserID: {UserID}, \n" +
                $"ContractNumberID: {ContractNumberID}, \n" +
                $"EmployeeID: {EmployeeID}, \n" +
                $"ContractDate: {ContractDate}, \n" +
                $"ContractAmount: {ContractAmount}, \n" +
                $"ContractDatePayment: {ContractDatePayment} ");
        }
    }
}
