using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_Task2
{
    class cCalc
    {
        public int summ;

        public cCalc()
        {
            summ = 0;
        }

        public int calculate(int digit)
        {
            if (is_Simple(digit) && digit > 0)
            {
                summ += digit;
            }
            return summ;
        }

        static bool is_Simple(int digit)
        {
            if (digit % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
