using System;
//Азаров Андрей
/*
Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000. 
Хорошим называется число, которое делится на сумму своих цифр. 
Реализовать подсчет времени выполнения программы, используя структуру DateTime.
*/
namespace Lesson2_Task6
{
    class Program
    {
        static void Main()
        {
            DateTime startTime = DateTime.Now;
            int j = 0;
            int tmp = 0, tmpNum = 0;

            for (int i=2;i<1000000;i++)
            {
                tmpNum = i;
                tmp = 0;
                while (tmpNum != 0)
                {
                    tmp += tmpNum % 10;
                    tmpNum /= 10;
                    //Console.Write("I="+i+" "+tmp+"#"+tmpNum+"@"+ tmpNum % 10);
                }
                //Console.Write("\n\n");
                if (i % tmp == 0) {
                    //Console.WriteLine("DONE "+tmp + "!!!" + tmpNum + "|");
                    j++;
                }
            }

            Console.WriteLine("Чисел, которое делится на сумму своих цифр {0}", j);
            Console.WriteLine("Выполнялось {0}",DateTime.Now-startTime);
            Console.ReadKey();
        }

    }
}
