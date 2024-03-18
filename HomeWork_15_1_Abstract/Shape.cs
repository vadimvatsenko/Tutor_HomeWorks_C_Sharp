using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_1_Abstract
{
    public abstract class Shape
    {
        private protected ConsoleColor Color;

        private protected Vector2 Position;

        protected Shape(ConsoleColor color, Vector2 position) 
        { 
            Color = color;
            Position = position;
        }

        public abstract void Draw();
        public abstract void FillDraw();
    }
}
