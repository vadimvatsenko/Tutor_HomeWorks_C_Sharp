using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Tickets
    {
        public DateTime InsuranceDateTime {  get; private set; } // дата составления заявки
        public string NubmerInsuranceID { get; private set; } // номер страховки
        public string TicketNumber { get; private set; }
        public DateTime OutDate { get; private set; }

        public Tickets(DateTime insuranceDateTime, Insurance insurance, DateTime outDate)
        {

            InsuranceDateTime = insuranceDateTime;
            NubmerInsuranceID = insurance.InsuranceNumberID;
            TicketNumber = IDGenerator.GenerateStringID(15);
            OutDate = outDate;
        }

        public void Print()
        {
            Console.WriteLine($"TicketNumber: {TicketNumber}, \n" +
                $"InsuranceDateTime: {InsuranceDateTime}, \n" +
                $"NubmerInsuranceID: {NubmerInsuranceID}, \n" +
                $"OutDate: {OutDate}");
        }
    }
}

// DONE
