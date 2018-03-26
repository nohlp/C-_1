using System;
//Азаров Андрей
/*
Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double,double). 
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)
*/
namespace Lesson6_Task1
{
    public delegate double Fun(double x);
    public delegate double Fun2(double x, double y);
    public delegate double Fun3(double x, double y);


    class Program
    {
        public static void Table(Fun3 F, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (a <= b)
            {
                for (double i = a; i < b; i += 0.6)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2}", a+i, F(a+i, i),i);
                }
                a += 1;
            }
            Console.WriteLine("---------------------");
        }


        public static double myFunctZ(double x,double y)
        {
            return Math.Sqrt(x*x*x +y*y);
        }
        public static double myFunctZ2(double x, double y)
        {
            return Math.Sqrt(y*x*x);
        }
        public static double myFunctZ3(double x, double y)
        {
            return y*Math.Sin(x);
        }
        static void Main(string[] args)
        {

            Table(new Fun3(myFunctZ), 0, 10);
            Table(new Fun3(myFunctZ2), 0, 10);
            Table(new Fun3(myFunctZ3), 0, 10);
            Console.ReadKey();
        }
    }
}
