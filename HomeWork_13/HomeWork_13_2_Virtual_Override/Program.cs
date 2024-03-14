using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

//Повторити малюнок. 
//Для цього створити базовий клас Body, який має 7 параметрів. 
	 
//· height – цілочислений тип
//· width - цілочислений тип
//· y - число з плаваючою комою подвійної точності.
//· x - числа з плаваючою комою подвійної точності.
//· ConsoleColor color – зберігає колір
//· symbol – зберігає символ
//· r - числа з плаваючою комою подвійної точності.
//Поля мають бути доступними лише в класах наслідниках.
//Клас Body має 2 перегружених конструктора. Перший ініціалізує висоту, ширину, координати, колір та символ.
//Другий ініціалізує радіус, координати, колір та символ. Клас має віртуальний порожній метод Draw. 
//Створіть клас Arm, Foot, Head, Toros. Всі класи мають наслідувати базовий клас Body,
//окрім цього кожен клас має викликати відповідний для нього конструктор базового класу та перевизначати метод Draw.
//Додатково клас Foot має enum Side з варіантами Right та Left.
//В мейні треба створити список типу Body, та додати до списку об’єкти Foot, Arm, Head та Toros. 

namespace HomeWork_13_2_Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Список и цикл; // объекты в список, потом перебор. Body - список
            List<Body> bodyList = new List<Body>()
            {
                //(new Head(55, 1, ConsoleColor.Red, '-', 5)),
                (new Head(55, 4, ConsoleColor.Red, '-', 4)),
                (new Tors (30, 12, 40, 9, ConsoleColor.Yellow, '/')),
                (new Arm(25, 4, 12, 12, ConsoleColor.Blue, '@')),
                (new Arm(25, 4, 73, 12, ConsoleColor.Cyan, '!')),
                (new Foot(10, 10, 40, 21, ConsoleColor.Green, '#', Side.Left)),
                (new Foot(10, 10, 60, 21, ConsoleColor.Blue, '*', Side.Right)),
            };

            foreach (Body body in bodyList)
            {
                body.Draw();
            }
        }
    }
}
