using System;
using System.IO;

//Азаров Андрей
/*
Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
Сделать меню с различными функциями и представьте пользователю выбор для какой функции и на 
каком отрезке находить минимум. Используйте массив делегатов. 
*/
namespace Lesson6_Task2
{
    public delegate double F(double x);
        class Program
        {
            public static double F2(double x)
            {
                return x * x - 50 * x + 10;
            }

            public static void SaveFunc(string fileName, double a, double b, double h,F F)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                double x = a;
                while (x <= b)
                {
                    bw.Write(F(x));
                    x += h;// x=x+h;
                }
                bw.Close();
                fs.Close();
            }
            public static double Load(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader bw = new BinaryReader(fs);
                double min = double.MaxValue;
                double d;
                for (int i = 0; i < fs.Length / sizeof(double); i++)
                {
                    // Считываем значение и переходим к следующему
                    d = bw.ReadDouble();
                    if (d < min) min = d;
                }
                bw.Close();
                fs.Close();
                return min;
            }
            static void Main(string[] args)
            {

                SaveFunc("data.bin", -100, 100, 0.5,new F(F2));
                Console.WriteLine(Load("data.bin"));

                Console.ReadKey();
            }
        }

}
