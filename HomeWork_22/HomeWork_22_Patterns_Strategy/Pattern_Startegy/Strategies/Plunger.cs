using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Startegy.Strategies
{
    internal class Plunger : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attack whith Plunger");
        }
    }
}
