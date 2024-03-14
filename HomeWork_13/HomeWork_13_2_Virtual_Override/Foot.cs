using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_2_Virtual_Override
{
    public enum Side
    {
        Right,
        Left
    }
    public class Foot : Body
    {
        private Side Side { get; set; }
        public Foot(int height, int width, double x, double y, ConsoleColor color, char symbol, Side side) : base(height, width, x, y, color, symbol)
        {
            Side = side;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition((int)X, (int)Y);

            if (Side == Side.Left)
            {

                for (int i = 0; i <= Height; i++)
                {
                    for (int j = 0; j <= Width - i; j++)
                    {
                        Console.WriteLine(Symbol);
                        Console.SetCursorPosition((int)X + i, (int)Y + j);
                    }

                    Console.SetCursorPosition((int)X, (int)Y);
                }
            }

            if (Side == Side.Right)
            {
                for (int i = 0; i <= Height; i++)
                {
                    for (int j = 0; j <= Width - i; j++)
                    {
                        Console.Write(Symbol);
                        Console.SetCursorPosition((int)X - i + Width - 1, (int)Y + j);
                    }
                    Console.SetCursorPosition((int)X, (int)Y);

                }
            }

        }
    }
}
