using System;

namespace Lesson_1
{
    public class Task_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес человека");
            float weight = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите рост человека");
            float height = int.Parse(Console.ReadLine());

            double imt = weight / Math.Pow(height, 2);
            Console.WriteLine("Индекс массы тела человека = {0}" , Math.Round(imt*10000));
        }
    }
}


