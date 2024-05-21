using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Contract // Договор
    {
        public string TourRegNumberID { get; private set; } // номер тура
        public DateTime ContractPaymentDeadLine { get; private set; } // Срок Оплаты
        public string UserID { get; private set; } // Id клиента
        public string ContractNumberID { get; private set; } // номер договора
        public string EmployeeID { get; private set; } // id сотрудника
        public DateTime ContractDate { get; private set; } // дата заключения контракта
        public double ContractAmount { get; private set; } // сумма контракта
        public DateTime ContractDatePayment {  get; private set; } // дата платежа

        public Contract(TourRegistration tourRegistration, DateTime contractPaymentDeadLine, User client, User employee, DateTime contractDate, double contractAmount, DateTime contractDatePayment)
        {
            TourRegNumberID = tourRegistration.TourRegistrationNumberID;
            ContractPaymentDeadLine = contractPaymentDeadLine;
            UserID = client.UserID;
            ContractNumberID = IDGenerator.GenerateStringID(5);
            EmployeeID = employee.UserID;
            ContractDate = contractDate;
            ContractAmount = contractAmount;
            ContractDatePayment = contractDatePayment;
        }

        public void Print()
        {
            Console.WriteLine($"TourRegNumberID: {TourRegNumberID}, \n" +
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
