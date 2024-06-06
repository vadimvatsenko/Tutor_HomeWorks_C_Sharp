using System;

namespace HomeWork_20_2_Async_Await // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Circle circles = new Circle(new Vector2(20, 15), ConsoleColor.Red, '#', 10);

             

            await Task.Run(() => circles.Draw());
           
            Console.SetCursorPosition(0, (int)(circles.position.y + 15f));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}




