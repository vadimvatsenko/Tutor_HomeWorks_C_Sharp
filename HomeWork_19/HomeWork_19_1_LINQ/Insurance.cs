using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Insurance // страховка
    {
        public string InsuranceNumberID { get; private set; } // номер id страховки
        public string UserID { get; private set; } // id клиента
        public string CompanyName { get; private set; } // название компании
        public DateTime InsuranceValidity {  get; private set; } // срок действия
        public double SumInsured { get; private set; } // страховая сумма
        public DateTime InsuranceIssueDate { get; private set; } // дата оформления

        public Insurance(User user, string companyName, DateTime insuranceValidity, double sumInsured, DateTime insuranceIssueDate) 
        {
            InsuranceNumberID = IDGenerator.GenerateStringID(8);
            UserID = user.UserID;
            CompanyName = companyName;
            InsuranceValidity = insuranceValidity;
            SumInsured = sumInsured;
            InsuranceIssueDate = insuranceIssueDate;
        }

        public void Print()
        {
            Console.WriteLine(
                $"InsuranceNumberID = {InsuranceNumberID}, \n" +
                $"UserID = {UserID}, \n" +
                $"CompanyName = {CompanyName}, \n" +
                $"InsuranceValidity = {InsuranceValidity}, \n" +
                $"SumInsured = {SumInsured}, \n" +
                $"InsuranceIssueDate = {InsuranceIssueDate}");
        }
    }
}

// DONE
