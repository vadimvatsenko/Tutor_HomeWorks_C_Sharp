using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_3_Encapsulation
{
    internal class Vector3
    {
        public enum TypeAngle
        {
            Radian,
            Degree,
        }

        public readonly double x;
        public readonly double y;
        public readonly double z;

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double AbsoluteValue // длинна вектора (величина)
        {
            get
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }
        }

        public Vector3 Normalized // где используется нормализация?
        {
            get
            {
                return new Vector3(x / AbsoluteValue, y / AbsoluteValue, z / AbsoluteValue);
            }
        }

        public static double Distance(Vector3 v1, Vector3 v2) // 
        {
            double dx = v2.x - v1.x;
            double dy = v2.y - v1.y;
            double dz = v2.z - v1.z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz); // корень
        }

        public static double Angle(Vector3 v1, Vector3 v2, TypeAngle typeAngle) // для чего?
        {

            double dotVector = CalculateDot(v1, v2); // Вычисляем скалярное произведение векторов
            /*double normalizeV1 = v1.Normalized.AbsoluteValue;
            double normalizeV2 = v2.Normalized.AbsoluteValue;*/
            double vector1Length = v1.AbsoluteValue; // Вычисляем длины (величины) векторов
            double vector2Length = v2.AbsoluteValue;

            double angleRadians = Math.Acos(dotVector / (vector1Length * vector2Length));
            //  Acos() возвращает числовое значение между 0 и π радианами для значения x ,
            //  лежащего в диапазоне от -1 до 1.

            if (typeAngle == TypeAngle.Degree)
            {
                //return angleRadians * (180.0 / Math.PI);
                return angleRadians * MyMath.FromRadToDeg;
            }
            else
            {
                return angleRadians;
            }

        }
        private static double CalculateDot(Vector3 v1, Vector3 v2) // скалярное произведение
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public void Print()
        {
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
    }
}
