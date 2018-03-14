using System;
//Азаров Андрей
/*
1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
*/

namespace Lesson3_Task1
{
    struct Complex
    {
        public double im,re;
        
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = im * x.im + re * x.im;
            y.re = re * x.im - im * x.re;
            return y;
        }

        public string _ToString()
        {

            return re + (im < 0 ? "" : "+") + im + "i";
        }
    }

    class cComplex
    {
        double im, re;
        public cComplex()
        {
            im = 0;
            re = 0;
        }
        public cComplex(double re,double im)
        {
            this.im = im;
            this.re = re;
        }
        public cComplex Plus(cComplex x)
        {
            cComplex y = new cComplex();
            y.im = this.im + x.im;
            y.re = this.re + x.re;
            return y;
        }

        public cComplex Minus(cComplex x)
        {
            cComplex y = new cComplex();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public cComplex Multi(cComplex x)
        {
            cComplex y = new cComplex();
            y.im = im * x.im + re * x.im;
            y.re = re * x.im - im * x.re;
            return y;
        }

        public string cToString()
        {
            return re + (im < 0 ? "" : "+") + im + "i";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("******************* Class cComplex ******************");

            Complex complex1;
            complex1.im = 1;
            complex1.re = 1;

            Complex complex2;
            complex2.im = 2;
            complex2.re = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result._ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine(result._ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine(result._ToString());


            Console.WriteLine("******************* Class cComplex ******************");

            cComplex cComplex1 = new cComplex(5,2);
            cComplex cComplex2 = new cComplex(-4,-5);

            cComplex cResult = cComplex1.Plus(cComplex2);
            Console.WriteLine(cResult.cToString());

            cResult = cComplex1.Minus(cComplex2);
            Console.WriteLine(cResult.cToString());

            cResult = cComplex1.Multi(cComplex2);
            Console.WriteLine(cResult.cToString());

            Console.ReadKey();
        }
    }
}
