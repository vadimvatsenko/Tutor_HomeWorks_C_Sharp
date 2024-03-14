using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Создать класс Vector3 с 3 полями x, y, z, только для чтения.
//Создать в нем перечисление TypeAngle со значениями Radian и Degree.
//Создать конструктор который инициализирует поля класса. Реализовать свойство normalized, которое возвращает нормированный вектор.
//Создать свойство absoluteValue, которое возвращает абсолютную величину вектора. Создать и реализовать статическую функцию Distance,
//который принимает 2 вектора и возвращает дистанцию между ними. Создать и реализовать статическую функцию Angle,
//которая принимает 2 вектора, тип угла и возвращает угол между этими двумя векторами в градусах или в радианах,
//использовать скалярное произведение векторов. Создайте метод Print для вывода трёх компонент.
//Создайте структуру MyMath. В ней реализуйте статичное свойство fromDegtoRad, которое должно возвращать определенную пропорцию(число),
//которое характеризирует переход от градусов в радианы. Также реализуйте статичное свойство fromRadtoDeg,
//которое должно возвращать определенную пропорцию(число), которое характеризирует переход от радиан в градусы.

namespace HomeWork_11_3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector1 = new Vector3(1, 5, 6);
            Vector3 vector2 = new Vector3(5, 11, 20);

            vector1.Print();
            vector1.Normalized.Print();

            Console.WriteLine(Vector3.Distance(vector2, vector1));

            Console.WriteLine(Vector3.Angle(vector1, vector2, Vector3.TypeAngle.Radian));
            Console.WriteLine(Vector3.Angle(vector1, vector2, Vector3.TypeAngle.Degree));
        }
    }
}
