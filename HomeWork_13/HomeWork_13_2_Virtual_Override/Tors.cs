using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_2_Virtual_Override
{
    public class Tors : Body
    {
        public Tors(int height, int width, double x, double y, ConsoleColor color, char symbol) : base(height, width, x, y, color, symbol)
        {
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition((int)X, (int)Y);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.WriteLine(Symbol);
                    Console.SetCursorPosition((int)X + j + 1, (int)Y + i);
                }
                Console.SetCursorPosition((int)X, (int)Y + i + 1);
            }

        }
    }
}
