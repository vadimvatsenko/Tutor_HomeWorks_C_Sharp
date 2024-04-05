using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17_2_Interfaces
{
    public abstract class Shape
    {
        private protected ConsoleColor Color;
        private protected Vector2 Position;
        private protected double SpeedX;
        private protected double SpeedY;

        public Shape(ConsoleColor color, Vector2 position, double speedX, double speedY) 
        {
            Color = color;
            Position = position;
            SpeedX = speedX;
            SpeedY = speedY;
        }

        public abstract void Draw();
        public abstract void MoveRight();
        public abstract void MoveLeft();
        public abstract void MoveUp();
        public abstract void MoveDown();


    }
}
