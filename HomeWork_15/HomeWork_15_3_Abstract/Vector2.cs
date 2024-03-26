﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_3_Abstract
{
    public struct Vector2
    {
        public double X; 
        public double Y;

        public static Vector2 Up { get; private set; } = new Vector2(0 , 0.1);
        public static Vector2 Down { get; private set; } = new Vector2 (0 , -0.1);
        public static Vector2 Left { get; private set; } = new Vector2 (-0.1 , 0);
        public static Vector2 Right { get; private set; } = new Vector2(0.1, 0);

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }
           
    }
}
