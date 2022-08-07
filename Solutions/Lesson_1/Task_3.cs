using System;

namespace Lesson_1
{
    public class Task_3
    {
        static void Main(string[] args)
        {
            float x1 = 100, x2 = 200, y1 = 100, y2 = 200;
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            Console.WriteLine("{0:F2}", r);
        }
    }
}
