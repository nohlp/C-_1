﻿using System;
//Азаров Андрей
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
namespace Lesson2_Task3
{
    class Program
    {
        int summ=0;
        public void Main(string[] args)
        {
            string summ_string;
            string line;
            do
            {
                line = Console.ReadLine();
                summ_string = calculate(Convert.ToUInt16(line)).ToString();

                Console.WriteLine("Cумма всех нечетных положительных чисел: {0} | {1}", summ_string,line);
            } while (line!="0");

            Console.WriteLine("Done!!!");
            Console.ReadKey();
        }

        public int calculate(int digit)
        {
            if (is_Simple(digit) && digit>0)
            {
                summ += digit;
            }
            return summ;
        }

        public bool is_Simple(int digit)
        {
            if (digit % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}