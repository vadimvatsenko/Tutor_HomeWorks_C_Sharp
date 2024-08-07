﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_1_LINQ
{
    public class Cities
    {
        public string CitiID { get; private set; }
        public string CitiName { get; private set; }

        public Cities(string name) 
        {
            CitiID = IDGenerator.GenerateStringID(20);
            CitiName = name;
        }

        public void Print()
        {
            Console.WriteLine($"CitiID: {CitiID}, CitiName: {CitiName}");
        }
    }
}

//DONE
