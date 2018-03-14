using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 
            int a = 10;
            int b = 53;
            int c;
            Console.Write("\n\n" + a + " " + b);
            c = a;
            a = b;
            b = c;

            Console.Write("\n" + a + " " + b);
            a = a + b; //a=a<<b;
            b = a - b; //b=b<<a;
            a = a - b; //a=a<<b;
            Console.Write("\n" + a + " " + b);

            Console.ReadKey();
        }
    }
}
