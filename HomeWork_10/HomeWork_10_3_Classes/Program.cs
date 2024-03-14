using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Создайте класс с названием Device.
// Этот класс должен содержать модель устройства как строка,
// название девайса, например ноутбук, планшет, поле с количеством устройств и поле с количеством брака.
// Создайте конструктор с 3 параметрами, который будет заполнять поля класса.
// Создайте метод Print, который будет выводить все данные об устройстве.
// Создайте метод CountNoDefective(). Этот метод должен возвращать количество не бракованных устройств.
// В Main создайте Цикл на 5 итераций и список объектов Device.
// Внутри цикла нужно создать 5 объектов и добавить каждый объект в список.
// После цикла отсортируйте все элементы списка по полю “Количество устройств”. 

namespace HomeWork_10_3_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>()
            {
                new Device("PS5", "SonyPlayStation 5", 10, 1), // 9
                new Device("SNES", "Super Nintendo", 20, 2), // 18
                new Device("Sega", "Sega Mega Drive 2", 6, 4), // 2
                new Device("Nintendo", "Nintendo Switch", 5, 3), // 2
                new Device("PC", "Ryzen/RTX3060TI", 1, 0) // 1
            };



            // newListDevice.Sort((d1, d2) => d1.CountNoDefective().CompareTo(d2.CountNoDefective()));

            devices.Sort((d1, d2) => d1.CountOfDevices.CompareTo(d2.CountOfDevices));



            for (int i = 0; i < devices.Count; i++)
            {
                devices[i].Print();
            }
        }
    }
}
