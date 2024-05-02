using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Tickets
    {
        public DateTime InsuranceDateTime {  get; private set; }
        public DateTime OutDate { get; private set; }

        private static int NextNumber = 1;
        public int NubmerInsurance { get; private set; } // номер страховки
        public int TicketNumber { get; private set; } = 0;

        public Tickets(DateTime insuranceDateTime, Insurance insurance, DateTime outDate)
        {
            InsuranceDateTime = insuranceDateTime;
            NubmerInsurance = insurance.Number;
            TicketNumber = NextNumber++;
            OutDate = outDate;
        }

        public void Print()
        {
            Console.WriteLine($"TicketNumber: {TicketNumber}, \n" +
                $"InsuranceDateTime: {InsuranceDateTime}, \n" +
                $"NubmerInsurance: {NubmerInsurance}, \n" +
                $"OutDate: {OutDate}");
        }
    }
}
