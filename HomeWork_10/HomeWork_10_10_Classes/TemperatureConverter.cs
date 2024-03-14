using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_10_Classes
{
    internal class TemperatureConverter
    {
        private double _celsius;
        private double _fahrenheit;

        public double Celsius
        {
            get { return _celsius; }
            set
            {
                if (value <= -100)
                {
                    Console.WriteLine("Должен быть больше -100");
                }
                else
                {
                    _celsius = value;
                }
            }
        }

        public double Fahrenheit
        {
            get { return _fahrenheit; }
            set
            {
                if (value <= -100)
                {
                    Console.WriteLine("Должен быть больше -100");
                }
                else
                {
                    _fahrenheit = value;
                }
            }
        }

        public double ConvertToFahrenheit()
        {
            return Celsius * 9 / 5 + 32;
        }

        public double ConvertToCelsius()
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
    }
}
