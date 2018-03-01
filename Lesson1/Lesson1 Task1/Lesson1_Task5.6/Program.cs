using System;
//Азаров Андрей
/*
5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
 */

namespace Lesson1_Task5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int consoleWidth = 40;
            int consoleHeight = 25;

            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);


            string drawData = "Азаров Андрей, Сыктывкар.";

            PrintText(drawData,10,5);

            Pause();
        }

        static void PrintText(string drawData,int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(drawData);

        }

        static void Pause()
        {
            Console.ReadKey();
        }
    }
}
