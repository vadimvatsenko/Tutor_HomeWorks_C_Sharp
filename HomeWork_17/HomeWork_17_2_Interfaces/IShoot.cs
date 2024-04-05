using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17_2_Interfaces
{
    public interface IShoot
    {
        public void Shoot(Shape bullet, Vector2 direction);
    }
}
