using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    internal interface IChangeColor
    {
        // Wall
        public void ChangeColor(Shape shape, ConsoleColor color);
    }
}
