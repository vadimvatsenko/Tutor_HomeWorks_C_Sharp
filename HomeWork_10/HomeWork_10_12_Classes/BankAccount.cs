using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_12_Classes
{
    public class BankAccount
    {
        static private float interestRate = 0.05f;
        private float balance;

        public static float InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value >= 0 && value <= 1)
                {
                    interestRate = value;
                }

            }
        }

        public float Balance
        {
            get { return balance; }
        }

        public void Deposit(float summ)
        {
            if (summ <= 0)
            {
                return;
            }
            balance += summ;

        }

        public void Withdraw(float summ)
        {
            if (summ <= 0)
            {
                return;
            }
            if (summ > balance)
            {
                return;
            }
            balance -= summ;
        }

        public void ApplyInterest()
        {
            balance += balance * interestRate;
        }
    }
}
