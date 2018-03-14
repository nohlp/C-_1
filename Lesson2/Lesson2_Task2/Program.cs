using System;
//Азаров Андрей
//Написать метод подсчета количества цифр числа.

namespace Lesson2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 134882093;
            string line= digit.ToString();
            int i = 0;
            foreach(char s in line)
            {
                //Console.WriteLine(" {0} ",s);
                i++;
            }
            Console.WriteLine($"{i} chars in string line {line}");

            Console.WriteLine("{0} chars in string line {1}",line.Length,line);
            Console.ReadKey();
        }
    }
}
