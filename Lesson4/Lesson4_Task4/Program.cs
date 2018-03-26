using System;

namespace Lesson4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new Print(80,50);
            //Если файла нет, то создается массив с произвольными элементами и сохраняется в файл.
            //При следующем старте данные из файла заносятся в массив.
            myArray mA = new myArray(10,11,10000,"matrix.txt");

            mA.PrintArray(0);

            int startPos = 0;

            p.PrintText("Сумма всех элементов начиная с "+startPos+" номера :"+mA.SummFromPos(startPos).ToString(), 10, 40);

            startPos = 2;
            p.PrintText("Сумма всех элементов начиная с " + startPos + " номера :" + mA.SummFromPos(startPos).ToString(), 10, 40);

            p.PrintText("Минимальное значение:" + mA.myMin.ToString(), 5, 41);
            p.PrintText("Максимальное значение:" + mA.myMax.ToString(), 5, 42);

            p.Pause();
        }
    }
}
