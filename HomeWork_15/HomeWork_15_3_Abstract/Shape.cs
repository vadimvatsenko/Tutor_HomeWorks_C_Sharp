﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_3_Abstract
{
    public abstract class Shape
    {
        private protected ConsoleColor Color;

        //private protected Vector2 Position;

        //public Vector2 Position; // модификатор доступа??

        private protected Vector2 position;
        public Vector2 Position
        {
            get
            {
                return position;
            }
            private protected set
            {
                position = value;
            }
        }

        public Shape(ConsoleColor color, Vector2 position) 
        { 
            Color = color;
            Position = position;
        }

        public abstract void FillDraw();

        public abstract void Draw();
        public abstract void Move(Vector2 direction);

    }
}
