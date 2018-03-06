using System;
//Андрей Азаров
/*
5. а) Написать программу, которая запрашивает массу и рост человека, 
      вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
   б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/

namespace Lesson2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            double indexOfBody;
            Console.WriteLine("Введите Ваш вес в кг:");
            weight = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Введите Ваш рост в м:");
            height = Convert.ToDouble(Console.ReadLine());

            indexOfBody = weight / (height * height);

            switch (indexOfBody)
            {
                case Double n when (n <= 16):
                {
                        Console.WriteLine("Выраженный дефицит массы тела(index={0:F}). {1:F}", indexOfBody, indexCalc(indexOfBody, 18.5, height));

                        break;
                }
                case Double n when (n <= 18.5):
                {
                        Console.WriteLine("Недостаточная (дефицит) масса тела(index={0:F}). {1:F}", indexOfBody, indexCalc(indexOfBody, 18.5, height));

                        break;
                }
                case Double n when (n <= 24.99):
                {
                        Console.WriteLine("Норма веса.");

                        break;
                }
                case Double n when (n <= 30):
                {
                        Console.WriteLine("Избыточная масса тела (предожирение)(index={0:F}). {1:F}", indexOfBody, indexCalc(indexOfBody, 24.99, height));

                        break;
                }
                case Double n when (n <= 35):
                {
                        Console.WriteLine("Ожирение первой степени(index={0:F}). {1:F}", indexOfBody, indexCalc(indexOfBody, 24.99, height));

                        break;
                }
                case Double n when (n <= 40):
                {
                        Console.WriteLine("Ожирение второй степени(index={0:F}). {1:F}", indexOfBody, indexCalc(indexOfBody, 24.99, height));

                        break;
                }
                case Double n when (n > 40):
                    {
                        Console.WriteLine("Ожирение третьей степени (морбидное)(index={0:F}). {1:F}", indexOfBody, indexCalc(indexOfBody, 24.99, height));

                        break;
                    }
            }
             
            Console.ReadKey();
        }

        static string indexCalc(double indexWeight1,double indexWeight2,double height)
        {
            double weight;
            //
            double weight1 = indexWeight1 * height * height;
            double weight2 = indexWeight2 * height * height;
            if (weight1>weight2)
            {
                weight = weight1 - weight2;
                return "Необходимо похудеть минимум на " + (int)weight + "кг.";
            }
            else
            {
                weight = weight2 - weight1;
                return "Необходимо набрать минимум на " + (int)weight + "кг.";
            }
            
            //return weight.ToString();
        }
    }
}
