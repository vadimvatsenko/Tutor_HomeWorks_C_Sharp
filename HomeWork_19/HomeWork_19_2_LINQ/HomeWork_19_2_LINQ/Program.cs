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

            List<Circle> circles = new List<Circle>(10);
            
            for (int i = 0; i < circles.Capacity; i++)
            {
                Vector2 position;
                bool positionIsValid;

                do
                {
                    position = new Vector2(rnd.Next(radius, Console.WindowWidth - radius), rnd.Next(radius, Console.WindowHeight - radius));
                    positionIsValid = true;

                    foreach (var circle in circles)
                    {
                        if (Vector2.Distance(position, circle.startPosition) < radius * 2)
                        {
                            positionIsValid = false;
                            break;
                        }
                    }

                } while (!positionIsValid);

                Circle newCircle = new Circle(i == 0? ConsoleColor.Green: ConsoleColor.Yellow, i == 0 ? '%': '#', position);
                circles.Add(newCircle);
            }

            List<Line> lines = new List<Line>(circles.Count - 1);
            
            for (int i = 1; i < circles.Count; i++) 
            {
                lines.Add(new Line(ConsoleColor.Red, '-', circles[0].startPosition, circles[i].startPosition));
            }
          
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


