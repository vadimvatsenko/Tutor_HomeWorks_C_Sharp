using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10_7_Classes
{

        struct Triangle
        {
            int _a, _b, _c, _h;

            public Triangle(int a, int b, int c, int h)
            {
                _a = a;
                _b = b;
                _c = c;
                _h = h;
            }

            public void CalcPerimeter(out int result)
            {
                result = _a + _b + _c;

            }

            public void Square(out int result)
            {
                result = (_a * _h) / 2;
                // Console.WriteLine($"Square: {result}");
            }
        }
    }

