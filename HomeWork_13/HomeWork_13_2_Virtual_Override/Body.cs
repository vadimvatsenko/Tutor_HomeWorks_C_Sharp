using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_2_Virtual_Override
{
    public class Body
    {
        // protected//
        protected int Height { get; set; }
        protected int Width { get; set; }
        protected double X { get; set; }
        protected double Y { get; set; }
        protected ConsoleColor Color { get; set; }
        protected char Symbol { get; set; }
        protected double R { get; set; }

        public Body(int height, int width, double x, double y, ConsoleColor color, char symbol)
        {
            Height = height;
            Width = width;
            X = x;
            Y = y;
            Color = color;
            Symbol = symbol;
        }

        public Body(double x, double y, ConsoleColor color, char symbol, double r)

        {
            X = x;
            Y = y;
            Color = color;
            Symbol = symbol;
            R = r;
        }

        public virtual void Draw()
        {

        }
    }
}
