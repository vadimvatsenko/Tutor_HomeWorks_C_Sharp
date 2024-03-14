using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_3_Encapsulation
{
    struct MyMath
    {
        public static double FromDegToRad
        {
            get
            {
                return Math.PI / 180.0;
            }
        }

        public static double FromRadToDeg
        {
            get
            {
                return 180.0 / Math.PI;
            }
        }
    }
}
