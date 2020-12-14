using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public Point(int a, int b, char ch)
        {
            x = a;
            y = b;
            c = ch;
        }

        internal void Move(MotionCommand mc)
        {
            switch (mc)
            {
                case MotionCommand.Down:
                    y++;
                    break;
                case MotionCommand.Left:
                    x--;
                    break;
                case MotionCommand.Right:
                    x++;
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
