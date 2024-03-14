using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Реализуйте класс CoordinateSystem, который будет реализовывать переход из декартовой в полярную систему и наоборот. Клас содержит:
//· Перечисление
//· Закрытые поля
//· Конструктор 
//· Свойства(запись через свойство осуществляется только внутри класса )
//· Методы перехода из одной системы в другую
//· Методы конвертации условных единиц 
//· Метод для вывода данных

namespace HomeWork_11_2_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoordinateSystem coordinate = new CoordinateSystem(5, 6, CoordinateSystem.TypeSystem.Decart); // декартовый
            coordinate.PrintData(CoordinateSystem.TypeSystem.Decart);

            coordinate.ConvertFromDecardToPolar(); // полярный
            coordinate.PrintData(CoordinateSystem.TypeSystem.Polar);

            coordinate.FromRadianToDegree();
            coordinate.PrintData(CoordinateSystem.TypeSystem.Polar);

            coordinate.FromDegreeToRadian();
            coordinate.PrintData(CoordinateSystem.TypeSystem.Polar);

            coordinate.ConvertFromPolarToDecard();
            coordinate.PrintData(CoordinateSystem.TypeSystem.Decart);



            /* coordinate.FromRadianToDegree(); // из радиан в степень
             coordinate.PrintData(CoordinateSystem.TypeSystem.Polar);

             coordinate.FromDegreeToRadian(); // из степени в радианы
             coordinate.PrintData(CoordinateSystem.TypeSystem.Polar);

             coordinate.ConvertFromDecardToPolar(); // обратно в декартовый
             coordinate.PrintData(CoordinateSystem.TypeSystem.Decart);*/
        }
    }
}
