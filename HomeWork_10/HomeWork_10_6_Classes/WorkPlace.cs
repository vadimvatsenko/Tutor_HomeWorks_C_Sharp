using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_6_Classes
{
    internal class WorkPlace
    {
        float experience;

        public float Experience // свойство класса WorkPlace
        {
            get { return experience; }
            set
            {
                if (value >= 0)
                {
                    experience = value;
                }
                else
                {
                    experience = 0;
                }
            }
        }
    }
}

