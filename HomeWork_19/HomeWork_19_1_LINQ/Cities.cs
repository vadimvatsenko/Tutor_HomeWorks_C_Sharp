using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Cities
    {
        private static int NextNumber = 1;
        public int CitiID { get; private set; } = 0;
        public string CitiName { get; private set; }

        public Cities(string name) 
        {
            CitiID = NextNumber++;
            CitiName = name;
        }

        public void Print()
        {
            Console.WriteLine($"CitiID: {CitiID}, CitiName: {CitiName}");
        }
    }
}

//DONE
