using System;
//Азаров Андрей
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
namespace Lesson2_Task3
{
    class Program
    {
        int summ=0;
        static void Main(string[] args)
        {
            string summ_string;
            string line;
            Calc Calc = new Calc();
            do
            {
                line = Console.ReadLine();

                Console.WriteLine("Cумма всех нечетных положительных чисел: {0} | {1}", Calc.calculate(Convert.ToUInt16(line)).ToString(), line);
            } while (line!="0");

            Console.WriteLine("Done!!!");
            Console.ReadKey();
        }


    }
}
