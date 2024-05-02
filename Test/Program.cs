using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {

        static void Main(string[] args)
        {
            State state1 = new State(); // Структура State
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state1 = state2;
            state2.x = 5; // state1.x=1 по-прежнему
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5


        }

    }

    struct State
    {
        public int x;
        public int y;

        public Country country;

        public State()
        {
            x =0; 
            y = 0;
            country = new Country();
        }
    }

    class Country
    {
        public int x;
        public int y;
    }
}

    


