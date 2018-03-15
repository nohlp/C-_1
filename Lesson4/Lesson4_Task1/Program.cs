using System;
//Азаров Андрей
/*
 1. Дан целочисленный массив из 20 элементов. 
 Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
 Написать программу, позволяющую найти и вывести количество пар элементов массива, 
 в которых хотя бы одно число делится на 3. 
 В данной задаче под парой подразумевается два подряд идущих элемента массива. 
 Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
*/
namespace Lesson4_Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Print print = new Print(80,60);
            int del_var = 3;
            int line = 0;
            int[] arr = { 6, 2,2, 9, -3,1,1,1, 6,1000,112,112,111};
            int count = 0;
            double tmp_var;

            for(int i = 1; i < arr.Length; i++)
            {
                tmp_var = arr[i] % del_var;

                if (arr[i - 1] % del_var == 0 || arr[i] % del_var == 0) {
                    count++;
                }
                print.PrintText("i=" + i + "  " + arr[i].ToString() + " % " + del_var + " = " + tmp_var.ToString() + "|     Пара( " + arr[i - 1].ToString() + " " + arr[i].ToString() + " ) count=" + count, 0, i);
                line++;
            }

            print.PrintText("Ответ: "+count.ToString(), 50, line+1);

            print.Pause();

        }
    }
}
