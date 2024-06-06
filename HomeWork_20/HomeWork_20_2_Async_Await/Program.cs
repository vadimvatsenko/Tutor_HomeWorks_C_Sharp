using System;

namespace HomeWork_20_2_Async_Await // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "HomeWork_20_2_Async_Await";
            
            List<Circle> circles = new List<Circle> { new Circle(new Vector2(20, 35), ConsoleColor.Red, '#', 15) };

             

            await Task.Run(() => circles[0].Draw());




           
            Console.SetCursorPosition(0, (int)(circles[0].position.y + 15f));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}




