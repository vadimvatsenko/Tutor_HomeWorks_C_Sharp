using System;

namespace MyApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
            
            await foreach(var i in GenerateNumbersAsync())
            {
                await Task.Run(() => Print(i));
            }
        }

        public static void Print(int a)
        {
            Console.WriteLine($"{a}^{2} = { a * a}");
        }

        public static async IAsyncEnumerable<int> GenerateNumbersAsync() // IAsyncEnumerable интерфейс который возвращает дженериковое значение.
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1500); // Имитация асинхронной операции
                yield return i; // yield - способна прерывать цикл на секунду, но не выходть с метода
            }
        }

        // 2ДЗ Круг = координаты круга и круг
        //



    }
}
