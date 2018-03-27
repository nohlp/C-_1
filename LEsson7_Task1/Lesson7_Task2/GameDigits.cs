using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Азаров Андрей
/*
Используя Windows Forms, разработать игру “Угадай число”. 
Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
Для ввода данных от человека используется элемент TextBox. 
*/
namespace Lesson7_Task2
{
    class GameDigits
    {
        public int FinishValue { get;private set; }
        public int UserInputhValue { get; set; }
        public int UserSteps { get;private set; }

        public GameDigits(int value)
        {
            FinishValue = value;
            UserSteps = 0;

        }

        public int CheckDigits(){
            UserSteps++;
            if (FinishValue == UserInputhValue)
            {
                return 100;
            }else if (this.FinishValue < UserInputhValue)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
