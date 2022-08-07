using System;

namespace Lesson_1
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();
            
            Console.WriteLine("Введите ваш рост");
            string height = Console.ReadLine();
            
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            
            Console.WriteLine(name + " " + surname + " Возраст:" + age + " Рост:" + height + " Вес:" + weight);
            Console.WriteLine("{0} {1} Возраст:{2} Рост:{3} Вес:{4}", name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname} Возраст:{age} Рост:{height} Вес:{weight}");
        }
    }
}

