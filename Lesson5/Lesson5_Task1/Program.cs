using System;
//Азаров Андрей
/*
Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры, и при этом цифра не может быть первой.
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
*/
namespace Lesson5_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин и пароль:");
            String input = Console.ReadLine();

            MyString myStr = new MyString(input);

            if (myStr.checkStr) {
                Console.WriteLine("CORRECT");
            } else
            {
                Console.WriteLine("NOT CORRECT");
            }
            Console.ReadKey();
        }
    }
}
