using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_Task3
{
    class Fraction
    {
        public int c;
        public int z;

        public Fraction() { }
        public Fraction(int _c,int _z)
        {
            this.c = _c;
            this.z = _z;
        }

        public static Fraction Plus(Fraction f1,Fraction f2)
        {
            Fraction fr = new Fraction();

            if (f1.z != f2.z)
            {
                fr.c = f1.c * f2.z + f2.c * f1.z;
                fr.z = f1.z * f2.z;
            }
            else
            {
                fr.c = f1.c + f2.c;
                fr.z = f1.z;
            }
            return fr;
        }
    }
}
