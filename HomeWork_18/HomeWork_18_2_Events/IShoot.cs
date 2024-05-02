using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_2_Events
{
    public interface IShoot
    {
        public void Shoot(Vector2 direction, ref Player player);
    }
}
