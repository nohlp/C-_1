using System;

namespace Lesson4_Task4
{
    class Print
    {
        public int windowWidth;
        public int windowHeight;
        static Print()
        {

        }
        public Print(int dimX, int DimY)
        {
            Console.SetBufferSize(dimX+1, DimY+1);
            Console.SetWindowSize(dimX, DimY);
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
            for (int i = 0; i < windowWidth; i += 4)
            {
                PrintText(i.ToString(), i, 0);
            }

            for (int j = 0; j < windowHeight; j++)
            {
                PrintText(j.ToString(), 0, j);
            }
        }

        public void Pause()
        {
            Console.ReadKey();
        }

    }
}
