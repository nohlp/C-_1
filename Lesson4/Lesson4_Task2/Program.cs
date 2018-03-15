using System;
//Азаров Андрей
/*
2. а) Дописать класс для работы с одномерным массивом. 
Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от 
начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, 
метод Inverse, меняющий знаки у всех элементов массива, Метод Multi, 
умножающий каждый элемент массива на определенное число, свойство MaxCount, 
возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.

б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл. 
*/
namespace Lesson4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new Print(80, 60);

            myArray myA1 = new myArray(10,2);
            //TASK A
            /*
                        p.PrintText("Summ: "+myA1.Sum.ToString(),0,myA1.myLenght);
                        myA1.PrintArray(0);
                        myA1.Inverse();
                        myA1.PrintArray(20);
                        p.PrintText("Summ after Inverse(): " + myA1.Sum.ToString(), 20, myA1.myLenght);
                        myA1.Multi(5);
                        myA1.PrintArray(50);
                        p.PrintText("Max: " + myA1.MaxCount.ToString(),50, myA1.myLenght);

            */

            //TASK B
                                    //(Размер,шаг для заполнения порядковым номером,файл с данными)
            //Если файл не создан, то создается файл и заполняется порядковым номером индекса массива
            myArray myA2 = new myArray(20,1,"data.txt");
            myA2.PrintArray(0);

            myA2.Multi(5);
            myA2.PrintArray(20);

            p.Pause();
        }
    }
}
