using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Создайте базовый класс Vehicle. В нем создайте автоматические свойства Model, Yearm Price, Brand,
//которые будут доступны в этом классе и производных. Создайте конструктор, который заполнит эти свойства.
//Создайте метод для вывода всех этих свойств, который будет доступен в этом класс и классах наследниках.
//Создайте класс Car и создайте свойство NumberOfDoors.
//Создайте конструктор, который с 5 параметрами, который должен вызвать конструктор базового класса,
//а пятый параметр инициализирует поле NumberOfDoors.
//Создайте публичный метод который выведет свойство  NumberOfDoors и вызовет метод базового класса.
//Создайте класс Motobike, который имеет свойство Type.
//Реализуйте в нем метод и конструктор так же как в классе Car.
//Метод Main должен выглядеть так

namespace HomeWork_12_1_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("Fusion", "Ford", 2020, 18000, 4); // 1
            car.Print();



            //Motobike motobike = new Motobike("Road King", "Harley-Davidson", 2007, 10500, "Chopper");
            //motobike.Print();
        }
    }
}
