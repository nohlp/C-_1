﻿using System;
//Азаров Андрей
/*
3. Напишите соответствующую функцию

Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
* Добавить упрощение дробей.
*/

    // P.S.  Не успеваю доделать реализацию умножения, деления и вычетания дробей. По идее все идентично сложению)
     

namespace Lesson3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(10,3);
            Fraction f2 = new Fraction(12, 3);

            Fraction f3 = Fraction.Plus(f1, f2);
            Console.WriteLine("Сумма дробей ровна {0}/{1}",f3.c,f3.z);

            Console.ReadLine();
        }
    }
}