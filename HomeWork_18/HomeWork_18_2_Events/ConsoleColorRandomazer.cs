using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    internal class ConsoleColorRandomazer
    {
        private static Random random = new Random();

        public static ConsoleColor GetRandomColor()
        {
      
            ConsoleColor randomColor = (ConsoleColor)random.Next(Enum.GetNames(typeof(ConsoleColor)).Length);
            return randomColor;
        }
    }
}
