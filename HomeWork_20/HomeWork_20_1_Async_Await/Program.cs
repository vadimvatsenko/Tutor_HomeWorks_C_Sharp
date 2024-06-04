using System;

namespace MyApp
{
    internal class Program
    {
        async Task Main(string[] args)
        {
            Console.WriteLine("Таблица умножения");
            Console.WriteLine("Введите число");

            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplicationTable(numb));



        }
        async Task<int> MultiplicationTable(int numb)
        {
            int mult = 0;
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(2000);
                mult = numb * i;
            }

            return mult;
        }

    }
}
