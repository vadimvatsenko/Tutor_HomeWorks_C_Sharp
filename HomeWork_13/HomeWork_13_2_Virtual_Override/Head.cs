﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_2_Virtual_Override
{
    public class Head : Body
    {
        public Head(double x, double y, ConsoleColor color, char symbol, double r) : base(x, y, color, symbol, r)
        {
        }



        public override void Draw()
        {

            Console.ForegroundColor = Color;
            Console.SetCursorPosition((int)X, (int)Y);

            // алгоритм Брезенхэма для рисования круга
            double step = 1.0 / R;
            for (double i = 0; i <= Math.PI / 2; i += step)
            {
                int x = (int)Math.Round(R * Math.Cos(i));
                int y = (int)Math.Round(R * Math.Sin(i));

                Console.SetCursorPosition((int)X + x, (int)Y + y);
                Console.Write(Symbol);
                Console.SetCursorPosition((int)X + x, (int)Y - y);
                Console.Write(Symbol);
                Console.SetCursorPosition((int)X - x, (int)Y + y);
                Console.Write(Symbol);
                Console.SetCursorPosition((int)X - x, (int)Y - y);
                Console.Write(Symbol);

                Console.SetCursorPosition((int)X + y, (int)Y + x);
                Console.Write(Symbol);
                Console.SetCursorPosition((int)X + y, (int)Y - x);
                Console.Write(Symbol);
                Console.SetCursorPosition((int)X - y, (int)Y + x);
                Console.Write(Symbol);
                Console.SetCursorPosition((int)X - y, (int)Y - x);
                Console.Write(Symbol);
            }

        }

    }
}
