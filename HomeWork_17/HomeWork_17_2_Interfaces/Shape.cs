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
        private protected double SpeedX;
        private protected double SpeedY;

        /*public Vector2 Position { get; protected set; }*/
        protected Vector2 position;
        public Vector2 Position => position;

        public Shape(ConsoleColor color, Vector2 position, double speedX, double speedY) 
        {
            Color = color;
            this.position = position;
            SpeedX = speedX;
            SpeedY = speedY;
        }

        public abstract void Draw();
        public abstract void Move(Vector2 direction);
        
    }
}
