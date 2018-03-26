using System;
using System.Collections.Generic;
using System.IO;
//Андрей Азаров
/*
 Подсчитать количество студентов:
а) учащихся на 5 и 6 курсах;
б)подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента.
Дополнительное домашнее задание 
*/


class Program
{
    static int MyDelegat(Collections st1, Collections st2)
    {
        return String.Compare(st1.firstName, st2.firstName);
    }
static void Main(string[] args)
{
    int bakalav = 0;
    int magistr = 0;

    List<Collections> list = new List<Collections>();
    DateTime dt = DateTime.Now;
    StreamReader sr = new StreamReader("students.txt");
    while (!sr.EndOfStream)
    {
        try
        {
            string[] s = sr.ReadLine().Split(';');
            list.Add(new Collections(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
            if (int.Parse(s[6]) < 5) bakalav++; else magistr++;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            if (Console.ReadKey().Key == ConsoleKey.Escape) return;
        }
    }
    sr.Close();
    list.Sort(new Comparison<Collections>(MyDelegat));
    Console.WriteLine("Всего студентов:" + list.Count);
    Console.WriteLine("Магистров:{0}", magistr);
    Console.WriteLine("Бакалавров:{0}", bakalav);
    //foreach (var v in list) Console.WriteLine(v.firstName);
    Console.WriteLine(DateTime.Now - dt);
    Console.ReadKey();
}
}