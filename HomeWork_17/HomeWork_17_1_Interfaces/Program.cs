using System;

/*Создать класс Person и четыре интерфейса: IRun, IFly, ISwim, IProperty. 
В интерфейсе IRun создать метод Run, в интерфейсах IFly, ISwim создайте методы с соответствующими названиями как и в IRun. 
Методы не принимают никаких параметров и ничего не возвращают. Создайте делегат CallMethod типа void, 
который не принимает параметры. Внутри интерфейса IProperty создайте метод Activate, который принимает параметр типа делегата.
Person должен реализовывать все четыре интерфейса, метод Activate должен вызывать переданный в качестве аргумента метод. 
Создайте объект Person в мейне и покажите работу ваших методов. В результате должен быть такой результат*/

namespace HomeWork_17_1_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Activate((person as IFly).Fly);
            person.Activate((person as IRun).Run);
            person.Activate((person as ISwim).Swim);

            IRun run = new Person();

        }
    }
}
