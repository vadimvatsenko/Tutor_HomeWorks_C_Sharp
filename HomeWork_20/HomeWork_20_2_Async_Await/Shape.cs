using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_20_2_Async_Await
{
    public abstract class Shape
    {
        public Vector2 position { get; protected set; }
        public ConsoleColor color { get; protected set; }

        public char symbol { get; }

        public Shape(Vector2 position, ConsoleColor color, char symbol)
        {
            this.position = position;
            this.color = color;
            this.symbol = symbol;
        }

        public abstract void Draw();
    }
}
