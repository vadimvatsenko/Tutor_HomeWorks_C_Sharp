using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создайте перегрузку для вашего класса Vector3.
// Реализуйте возможность суммирования 2 векторов,
// разность 2 векторов,
// инкремента,
// умножение числа на вектор,
// сравнение векторов
// и перегрузку оператора !=
// Перегрузку оператора != реализовать через оператор ==

namespace HomeWork_16_1_Overloading_operators
{
    struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
        }
        public static Vector3 operator +(Vector3 v1, Vector3 v2) // суммирование векторов
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z); // разность векторов
        }

        public static Vector3 operator ++(Vector3 v1) // инкремент
        {
            return new Vector3(++v1.x, ++v1.y, ++v1.z);
        }

        public static Vector3 operator *(Vector3 v1, int val) // умножение на число // вектор
        {
            return new Vector3(v1.x * val, v1.y * val, v1.z * val);
        }

        public static bool operator <(Vector3 v1, Vector3 v2) // сравнение векторов
        {
            return (v1.x + v1.y + v1.z) < (v2.x + v2.y + v2.z);
        }

        public static bool operator >(Vector3 v1, Vector3 v2) // сравнение векторов
        {
            return (v1.x + v1.y + v1.z) > (v2.x + v2.y + v2.z);
        }

        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            /*return ((v1.x != v2.x) || (v1.y != v2.y) || (v1.z != v2.z));*/
            return !(v1 == v2);
        } 

        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            return ((v1.x == v2.x) && (v1.y == v2.y) && (v1.z == v2.z));
        }
    }
}
