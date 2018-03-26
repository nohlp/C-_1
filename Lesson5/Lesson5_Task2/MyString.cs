using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson5_Task2
{
    class MyString
    {
        public string str;
        bool InputCorrect = false;

        public MyString(string str)
        {
            this.str = str;
        }

        public void ChangeStr(char myChar)
        {
            string[] tmpS;
            int tmpSlenght;

            tmpS = this.str.Split(" ");

            for (int i = 0; i < tmpS.Length; i++)
            {
                tmpSlenght = tmpS[i].Length-1;
                if (tmpS[i][tmpSlenght] != myChar)
                {
                    Console.Write(tmpS[i]+" ");
                    //Console.Write(tmpS[i][tmpSlenght] + " "+ myChar + " | "+ tmpS[i]+"\n\r");
                }
            }
        }

        public void MaxStr()
        {
            string[] tmpS;
            int maxStrCount;
            string maxString;

            tmpS = this.str.Split(" ");
            maxString = tmpS[0];
            maxStrCount = tmpS[0].Length;
            for (int i = 0; i < tmpS.Length; i++)
            {
                if (tmpS[i].Length > maxStrCount)
                {
                    maxStrCount = tmpS[i].Length;
                    maxString = tmpS[i];
                }
            }
            Console.WriteLine("Самое длинное слово "+ maxString +". "+maxStrCount+" символов.");
        }

        public string ShowStr(int n)
        {
            string[] tmpS;

            tmpS = this.str.Split(" ");
            for (int i=0;i< tmpS.Length;i++)
            {
                if (tmpS[i].Length<=n)
                {
                    Console.WriteLine(tmpS[i]+" Длина слова:"+ tmpS[i].Length + " символов.");
                }
            }
            return "";
        }

        public bool checkStr
        {
            get
            {
                if (this.str.Length > 2 && this.str.Length < 10)
                {
                    Regex re = new Regex("^[aA-zZ][^0-9]*[a-zA-Zа-яА-Я ]{2,10}");
                    InputCorrect = re.IsMatch(this.str);
                    return InputCorrect;
                }
                return InputCorrect;
            }

        }


    }
}
