using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_4_Classes
{
    internal class Components
    {
        double x; // float и double представляют вещественные числа
        double y;
        double z;

        public Components() : this(5.5)
        { }
        public Components(double x) : this(x, 6.6)
        {
            this.x = x;
        }
        public Components(double x, double y) : this(x, y, 7.7)
        {
            this.x = x;
            this.y = y;
        }

        public Components(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double GetAbsoluteValue()
        {
            double absoluteMagnitude = Math.Sqrt(x * x + y * y + z * z);
            return absoluteMagnitude;
            //float absoluteValue = Math.Abs(this.x) + Math.Abs(this.y) + Math.Abs(this.z);
            // Console.WriteLine(absoluteValue);
        }
    }
}
