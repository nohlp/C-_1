using System;
//Азаров Андрей
/*
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); 
где m-масса тела в килограммах, h - рост в метрах
*/

namespace Lesson1_Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nВведите Ваш рост:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите Ваш вес:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш индекс массы тела(ИМТ) равен {(weight/(height*height)):F}");

            Console.ReadKey();
        }
    }
}
