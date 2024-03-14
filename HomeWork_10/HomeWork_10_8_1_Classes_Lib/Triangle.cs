namespace HomeWork_10_8_1_Classes_Lib
{
    public class Triangle
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
        }
    }
}
