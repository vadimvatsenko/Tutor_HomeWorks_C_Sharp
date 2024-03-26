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

        private protected int SpeedX;
        private protected int SpeedY;

        /*        public abstract int Numb // австосвойство // можно объявить, без реализации
                {
                    get;

                    set;
                }*/

        public Shape(ConsoleColor color, Vector2 position, int speedX, int speedY) 
        { 
            Color = color;
            Position = position;
            SpeedX = speedX;
            SpeedY = speedY;
        }

        public abstract void Draw();
        public abstract void FillDraw();

        public abstract void MoveRight();
        public abstract void MoveLeft();
        public abstract void MoveUp();
        public abstract void MoveDown();

    }
}
