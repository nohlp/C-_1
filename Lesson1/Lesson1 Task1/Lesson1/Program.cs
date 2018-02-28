using System;
//Азаров Андрей
/*
Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку.

а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.
*/

namespace Lesson1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите Ваше имя:");
            string fname = Console.ReadLine();
            Console.Write("\nВведите Вашу фамилию:");
            string sname = Console.ReadLine();
            Console.Write("\nВведите Ваш возраст:");
            string age = Console.ReadLine();
            Console.Write("\nВведите Ваш рост:");
            string height = Console.ReadLine();
            Console.Write("\nВведите Ваш вес:");
            string weight = Console.ReadLine();

            Console.WriteLine("1: Вы ввели имя- "+fname+", фамилия- "+ sname+", возраст- "+ age+", рост- "+ height+", вес- "+weight);
            Console.WriteLine("2: Вы ввели имя- {0}, фамилия- {1}, возраст- {2}, рост- {3}, вес- {4}",fname,sname,age,height, weight);
            Console.WriteLine($"3: Вы ввели имя- {fname}, фамилия- {sname}, возраст- {age}, рост- {height}, вес- {weight}");
            Console.ReadKey();
        }
    }
}
