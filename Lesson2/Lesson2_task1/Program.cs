using System;
//Азаров Андрей
//Написать метод возвращающий минимальное из трех чисел.

namespace Lesson2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;
            a = 70;
            b = 30;
            c = 50;
            if (a < b) { 
                min = a;
            }
            else if(b<c){
                min = b;
            }
            else { min = c; }

            Console.WriteLine("Min value of a={0}, b={1}, c={2} is {3}", a, b, c, min);

            Console.WriteLine("Min value of a={0}, b={1}, c={2} is {3}", a, b, c, ((a<b)?a:(b<c)?b:c));

            Console.ReadKey();
        }
    }
}
