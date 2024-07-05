using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Startegy.Strategies
{
    public class Broom : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attack with Broom");
        }
    }
}
