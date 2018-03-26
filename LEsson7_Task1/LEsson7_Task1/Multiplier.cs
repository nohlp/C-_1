using System;
using System.Collections.Generic;
using System.Windows.Forms;

//Азаров Андрей
/*
1. а) Добавить в программу “Удвоитель” подсчет количества отданных команд удвоителю.
б) Добавить меню и команду “Играть”. При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов.
в) * Добавить кнопку “Отменить”, которая отменяет последние ходы. 
*/
namespace LEsson7_Task1
{
    class Multiplier
    {
        public int CurrentValue { get; private set; }
        public int FinishValue { get; set; }
        public int commandCount;
        Stack<int> myStack;

        public Multiplier(int FinishValue)
        {
            this.commandCount = 0;
            this.FinishValue = FinishValue;
            this.CurrentValue = 1;
            myStack = new Stack<int>();
        }

        public void Plus()
        {
            Push(this.CurrentValue);
            this.CurrentValue++;
        }
        public void Mult()
        {
            Push(this.CurrentValue);
            this.CurrentValue*=2;
        }

        public void Reset()
        {
            myStack.Clear();
            this.CurrentValue = 1;
            this.commandCount++;
        }

        public void Back()
        {
            if (myStack.Count > 0)
            {
                this.CurrentValue = myStack.Pop();
                this.commandCount++;
            }
        }

        public void Push(int value)
        {

            myStack.Push(value);
            this.commandCount++;
        }

        public int Check()
        {
            if (this.CurrentValue > this.FinishValue)
            {
                return 1;
            }
            else if (this.CurrentValue == this.FinishValue)
            {
                return 200;
            }
            return 0;
        }


    }
}
