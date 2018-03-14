using System;
//Андрей Азаров
/*
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    Достаточно решить 4 задачи. 
 */

namespace LEsson2_task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            int summ=0;

            Console.Write("Сумма чисел от "+a+" до "+b+ " ровна " + calcRec(a, b, summ).ToString());
            Console.ReadKey();
        }
        static int calcRec(int a,int b,int summ)
        {
            if (a<=b)
            {
                summ += a;
                a++;
                return calcRec(a,b,summ);
            }
            return summ;
        }
    }
}
