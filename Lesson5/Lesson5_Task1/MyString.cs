using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson5_Task1
{
    class MyString
    {
        public string str;
        bool InputCorrect = false;

        public MyString(string str)
        {
            this.str = str;
        }

        public bool checkStr
        {
            get
            {
                if (this.str.Length >2 && this.str.Length < 10)
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
