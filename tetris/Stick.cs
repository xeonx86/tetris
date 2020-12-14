using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Stick : Figure
    {

        public Stick(int x, int y, char ch)
        {
            points[0] = new Point(x, y, ch);
            points[1] = new Point(x, y+1, ch);
            points[2] = new Point(x, y+2, ch);
            points[3] = new Point(x, y+3, ch);
        }


    }
}
