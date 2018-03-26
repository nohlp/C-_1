using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson4_Task4
{
    class myArray
    {
        int dim;
        int min,max;
        int[,] myA;
        public string[] tmpA;
        public Print p = new Print(80,50);


        public myArray(int dim,int min, int max,string filename)
        {
            this.dim = dim;
            this.min = min;
            this.max = max;

            string[] tmpLine;

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(filename);
                this.dim = Convert.ToInt32(streamReader.ReadLine());

                myA = new int[this.dim, this.dim];
                tmpA = new string[this.dim];
                tmpLine = new string[this.dim];

                tmpA = new string[this.dim];
                    for (int i = 0; i < this.dim; i++)
                    {
                        tmpA[i] = streamReader.ReadLine();
                        tmpLine =tmpA[i].ToString().Split("|");

                        for (int j=0;j<this.dim;j++)
                        {
                            myA[i, j] = Convert.ToInt32(tmpLine[j]);
                        }
                    }
            }
            catch (FileNotFoundException)
            {
                myA = new int[this.dim, this.dim];
                tmpA = new string[this.dim];
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

        public int SummFromPos(int startPos)
        {
            int summ = 0;
            for (int i=startPos;i<this.dim;i++)
            {
                for (int j = startPos; j < this.dim; j++)
                {
                    summ += myA[i, j];
                }
            }
            return summ;
        }

        public void FillArray()
        {
                Random rnd = new Random();
                for (int i = 0; i < this.dim; i++)
                {
                    for (int j = 0; j < this.dim; j++)
                    {
                        myA[i, j] = rnd.Next(min, max + 1);
                    }
                }
        }

        public void Write(string filename)
        {
            FillArray();
            string[] s = new string[dim];
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.WriteLine(dim);

            for (int i=0;i< this.dim;i++)
            {
                for (int j = 0; j < this.dim; j++)
                {
                    s[i] += myA[i,j]+"|";

                }

                streamWriter.WriteLine(s[i]);
            }
            streamWriter.Close();
        }

        public void PrintArray(int position)
        {
            for (int i = 0; i < this.dim; i++)
            {
                for (int j = 0; j < this.dim; j++) {
                    p.PrintText(myA[i, j].ToString(), position+j, i);
                }
            }
        }
        public void PrintTmpArray(int position)
        {
            for (int i = 0; i < this.dim; i++)
            {
                p.PrintText(tmpA[i], position+i+3, i+3);
            }
        }



        public int myLenght
        {
            get {
                return myA.Length;
            }
        }
        public int myMin
        {
            get
            {
                int min = myA[0,0];
                for (int i = 0; i < this.dim; i++)
                {
                    for (int j = 0; j < this.dim; j++)
                    {
                        if (myA[i, j] < min) min = myA[i, j];
                    }
                }
                return min;
            }
        }
        public int myMax
        {
            get
            {
                int max = myA[0, 0];
                for (int i = 0; i < this.dim; i++)
                {
                    for (int j = 0; j < this.dim; j++)
                    {
                        if (myA[i, j] > max) max = myA[i, j];
                    }
                }
                return max;
            }
        }
    }
}
