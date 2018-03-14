using System;
//Азаров Андрей
/*
Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains). 
Используя метод проверки логина и пароля, написать программу: 
    пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.
*/
namespace Lesson2_Task4
{
    class Program
    {
        string login, password;
        
        static void Main(string[] args)
        {
            bool access_level = false;
            string login, password;
            int count=0;

            Auth Auth = new Auth();

            do {
                count++;
                Console.WriteLine("Введите пользователя:");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();

                if(Auth.userCheck(login, password))
                {
                    access_level = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Имя пользователя и пароль не совпадают! Попробуйте еще раз.");
                }
            }
            while (count!=3);
            if (access_level)
            {
                Console.WriteLine("Доспут разрешен");
            }
            else
            {
                Console.WriteLine("Доспут не разрешен");
            }
            Console.ReadKey();
        }
    }
}
