using System;

namespace Lesson1_Task5._6
{
    class Draw
    {
        public int windowWidth;
        public int windowHeight;
        static Draw()
        {

        }
        public Draw(int dimX, int DimY)
        {
            windowWidth = dimX;
            windowHeight = DimY;
        }

        public void PrintText(string drawData, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(drawData);

        }

        public void drawDigitBorder()
        {
            for (int i= 0; i < windowWidth; i+=4)
            {
                PrintText(i.ToString(), i, 0);
            }

            for(int j = 0; j < windowHeight; j++)
            {
                PrintText(j.ToString(), 0, j);
            }
        }

    }
}
