using System;
//Азаров Андрей
/*
2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран; 
Используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение.
*/

namespace Lesson3_Task2
{
    class Program
    {
        static void getDigit()
        {

        }
        static void Main(string[] args)
        {
            int x;
            bool inputFlag=false;
            int d;

            cCalc Calc = new cCalc();

            do
            {
                Console.WriteLine("Введите число:");
                inputFlag = int.TryParse(Console.ReadLine(), out d);
                if (inputFlag)
                {
                    Console.WriteLine("Cумма всех нечетных положительных чисел: {0}", Calc.calculate(Convert.ToUInt16(d)).ToString());
                }
                else
                {
                    Console.WriteLine("Ошибка ввода.");
                }

            } while (d!=0);

            Console.WriteLine("Done!!!");
            Console.ReadKey();

        }
    }
}
