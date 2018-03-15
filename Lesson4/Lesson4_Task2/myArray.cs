using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson4_Task2
{
    class myArray
    {
        int[] myA;
        Print p = new Print(40,40);


        public myArray(int dim, int step,string filename)
        {
            myA = new int[dim];

            for (int i = 0; i < myA.Length; i += step)
            {
                myA[i] = i;
            }

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(filename);
                int sizeDim = Convert.ToInt32(streamReader.ReadLine());
                myA = new int[sizeDim];
                for (int i = 0; i < sizeDim; i++)
                    myA[i] = Convert.ToInt32(streamReader.ReadLine());
            }
            catch (FileNotFoundException)
            {
                p.PrintText("Файл отсутствует",30,10);
                Write(filename);
                p.PrintText("!!!Файл создан!!!", 30, 11);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                p.PrintText(ex.ToString(),30,30);
            }
            finally
            {
                streamReader?.Close();
            }

        }
        public myArray(int dim, int step)
        {
            myA = new int[dim];

            for (int i = 0; i < myA.Length; i += step)
            {
                myA[i] = i;
            }

        }

        public void Write(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.WriteLine(myA.Length);

            foreach (int row in myA)
            {
                streamWriter.WriteLine(row);
            }
            streamWriter.Close();
        }

        public void PrintArray(int position)
        {
            for (int i = 0; i < myA.Length; i++)
            {
                p.PrintText(myA[i].ToString(), position, i);
            }


        }
        public void Inverse()
        {
            for (int i=0;i<myA.Length;i++)
            {
                myA[i] = -myA[i];
            }
        }
        public void Multi(int m)
        {
            for (int i = 0; i < myA.Length; i++)
            {
                myA[i] = myA[i]*m;
            }

        }
        public int Sum
        {
            get {
                int summ=0;
                for (int i = 0; i < myA.Length; i++)
                {
                    summ += myA[i];
                    //p.PrintText("i: " + i + " myA[" + i + "]=" + myA[i] + "   summ=" + summ, 5,i);
                }
                return summ;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = myA[0];
                for (int i = 1; i < myA.Length; i++)
                    if (myA[i] > max) max = myA[i];
                return max;
            }
        }

        public int myLenght
        {
            get {
                return myA.Length;
            }
        }
    }
}
