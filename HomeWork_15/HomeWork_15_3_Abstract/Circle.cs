﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_3_Abstract
{
    internal class Circle : Shape
    {
        private double R;
        public Circle(ConsoleColor color, Vector2 position, double r) : base(color, position)
        {
            R = r;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.SetCursorPosition(startX, startY);

            double step = 1.0 / R;

            for (double i = 0; i <= Math.PI / 2; i += step)
            {
                int x = (int)Math.Round(R * Math.Cos(i));
                int y = (int)Math.Round(R * Math.Sin(i));

                Console.SetCursorPosition(startX + x, startY + y);
                Console.Write(' ');
                Console.SetCursorPosition(startX + x, startY - y);
                Console.Write(' ');
                Console.SetCursorPosition(startX - x, startY + y);
                Console.Write(' ');
                Console.SetCursorPosition(startX - x, startY - y);
                Console.Write(' ');
                Console.SetCursorPosition(startX + y, startY + x);
                Console.Write(' ');
                Console.SetCursorPosition(startX + y, startY - x);
                Console.Write(' ');
                Console.SetCursorPosition(startX - y, startY + x);
                Console.Write(' ');
                Console.SetCursorPosition(startX - y, startY - x);
                Console.Write(' ');
            }
        }

        public override void FillDraw()
        {
            Console.ForegroundColor = Color;
            Console.BackgroundColor = Color;

            int startX = (int)Position.X;
            int startY = (int)Position.Y;

            Console.SetCursorPosition(startX, startY);

            double step = 1.0 / R;

            for (double i = 0; i <= Math.PI / 2; i += step)
            {
                int x = (int)Math.Round(R * Math.Cos(i));
                int y = (int)Math.Round(R * Math.Sin(i));


                for (int j = startY - y; j <= startY + y; j++)
                {
                    Console.SetCursorPosition(startX - x, j);
                    Console.Write(' ');
                    Console.SetCursorPosition(startX + x, j);
                    Console.Write(' ');
                }

                Console.SetCursorPosition(startX, startY + y);
                Console.Write(' ');
                Console.SetCursorPosition(startX, startY - y);
                Console.Write(' ');
            }
        }

        public override void Move(Vector2 direction)
        {
            Position.X += direction.X;
            Position.Y += direction.Y;

        }
    }
}


