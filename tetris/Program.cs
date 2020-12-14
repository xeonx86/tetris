﻿using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            int x1, y1;
            char ch = '*';
            x1 = 3;
            y1 = 4;
            int x2 = 5;
            int y2 = 4;
            Draw(x1, y1, ch);
            Draw(x2, y2, ch);
            Console.ReadLine();
        }

        static void Draw(int x,int y, char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
    }
}
