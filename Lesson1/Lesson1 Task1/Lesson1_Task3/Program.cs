using System;

/*Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
* Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;

Написать программу обмена значениями двух переменных
а) с использованием третьей переменной;
б) *без использования третьей переменной.

*/
namespace Lesson1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, x2 =0,  y1 = 0, y2 = 0;
            Console.Write("Введите значение координаты первой точки X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение координаты первой точки Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение координаты первой точки X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение координаты первой точки Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расстояние между точками {0:F2} ", calculate(x1, x2, y1, y2));


            //Task 
            int a = 10;
            int b = 53;
            int c;
            Console.Write("\n\n" +a + " " + b);
            c = a;
            a = b;
            b = c;
            
            Console.Write("\n" + a + " " + b);
            a = a + b; //a=a<<b;
            b = a - b; //b=b<<a;
            a = a - b; //a=a<<b;
            Console.Write("\n" + a + " " + b);

            Console.ReadKey();
        }

        static double calculate(int x1,int x2,int y1,int y2) {

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
