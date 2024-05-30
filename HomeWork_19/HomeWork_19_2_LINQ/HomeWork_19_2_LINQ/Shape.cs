using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_19_2_LINQ
{
    public abstract class Shape
    {
        private protected ConsoleColor color;
        public Vector2 startPosition { get; private set; }
        private protected char symbol;

        public Shape(ConsoleColor color, char symbol, Vector2 startPosition) 
        { 
            this.color = color;
            this.startPosition = startPosition;
            this.symbol = symbol;
        }

        public abstract void Draw();
    }
}
