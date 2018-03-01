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
            int consoleWidth = 80;
            int consoleHeight = 25;

            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.SetBufferSize(consoleWidth, consoleHeight);


            string drawData = "Азаров Андрей, Сыктывкар.";

            Draw Draw = new Draw(consoleWidth,consoleHeight);
            Draw.drawDigitBorder();
            string drawDataLenght = "Длина строки "+drawData.Length.ToString()+" символа";

            Draw.PrintText(drawData, calculateCenter(consoleWidth, drawData.Length), (int)(consoleHeight/2));
            Draw.PrintText(drawDataLenght, calculateCenter(consoleWidth, drawDataLenght.Length), (int)(consoleHeight / 2)+1);
            control control = new control();
            control.Pause();

        }

        static int calculateCenter(int consoleWidth,int stringLenght)
        {
            int startPosition;
            startPosition = (int)(consoleWidth / 2 - stringLenght / 2);
            return startPosition > 0 ? startPosition : 0;
        }

    }
}
