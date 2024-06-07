using System;

namespace HomeWork_20_2_Async_Await // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "HomeWork_20_2_Async_Await";
            Console.BufferWidth = 120;
            Console.WindowWidth = 120;
            Console.BufferHeight = 70;
            Console.WindowHeight = 70;
            /*Circle circle =  new Circle(new Vector2(20, 35), ConsoleColor.Red, '#', 15);

            

            await Task.Run(() => circle.Draw());

            Console.SetCursorPosition(0, (int)(circle.position.y + 20f));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Program end");*/

            Circle2 mainCircle = new Circle2(new Vector2(20, 35), ConsoleColor.Red, '#', 15);

            //await Task.Run(() => mainCircle.CircleDrawAsync());

            await foreach(var c in mainCircle.CircleDrawAsync())
            {
                Circle2 secondCircle = new Circle2(new Vector2(c.x + 40, c.y), ConsoleColor.Magenta, '&', 2);

                await secondCircle.FillDraw(secondCircle.position.x, secondCircle.position.y) ;
            }
           
        }
    }
}




