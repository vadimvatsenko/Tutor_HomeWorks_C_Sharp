using System;

namespace HomeWork_20_2_Async_Await // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Shape circles = new Circle(new Vector2(10, 10), ConsoleColor.Red, '#', 5);

            await Task.Run(() => circles.Draw()); 
           
            Console.SetCursorPosition(0, (int)(circles.position.y + 5f));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
