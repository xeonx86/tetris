﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class squreDraw : Figure
    {
        public squreDraw(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x+1, y, sym);
            points[2] = new Point(x, y+1, sym);
            points[3] = new Point(x+1, y+1, sym);
        }


    }
}
