using HomeWork_19_2_LINQ;
using System;
using System.Security.Cryptography.X509Certificates;

public class DrawLineBresenham
{
    public static void Main(string[] args)
    {
        int radius = 4;
        Random rnd = new Random();

        while (true)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();

            List<Circle> circles = new List<Circle>()
            {
                new Circle(ConsoleColor.Green, '%', new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius))),
                new Circle(ConsoleColor.Yellow, '#', new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius))),
                new Circle(ConsoleColor.Yellow, '#', new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius))),
                new Circle(ConsoleColor.Yellow, '#', new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius))),
                new Circle(ConsoleColor.Yellow, '#', new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius))),
                new Circle(ConsoleColor.Yellow, '#', new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius))),
            };

            List<Line> lines = new List<Line>()
            {
                new Line(ConsoleColor.Red, '-', circles[0].startPosition, circles[1].startPosition),
                new Line(ConsoleColor.Red, '-', circles[0].startPosition, circles[2].startPosition),
                new Line(ConsoleColor.Red, '-', circles[0].startPosition, circles[3].startPosition),
                new Line(ConsoleColor.Red, '-', circles[0].startPosition, circles[4].startPosition),
                new Line(ConsoleColor.Red, '-', circles[0].startPosition, circles[5].startPosition),

            };

            var sortLines = lines.OrderByDescending(l => Vector2.Distance(l.startPosition, l.endPosition)).ToList().Select(line => line);

            switch (keyInfo.Key)
            {
                case ConsoleKey.G:

                    foreach (var c in circles)
                    {
                        c.Draw();
                    }

                    foreach (var l in sortLines)
                    {
                        l.Draw();                       
                    }
                    break;
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}


