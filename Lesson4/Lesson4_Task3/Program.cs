using System;
//Андрей Азаров
/*
Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
*/
namespace Lesson4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int wSize = 80;
            int hSize = 30;
            Print p = new Print(80,50);

            Console.Write("Введите имя пользователя:");
            string log=Console.ReadLine();
            Console.Write("Введите имя пароль:");
            string pass = Console.ReadLine();


            Login login = new Login(log,pass);
            if (login.LOGGED)
            {
                p.PrintText("CORRECT", wSize / 2, hSize / 2);
            }
            else {
                p.PrintText("NOT CORRECT", wSize / 2, hSize / 2);
            }

            p.Pause();
        }
    }
}
