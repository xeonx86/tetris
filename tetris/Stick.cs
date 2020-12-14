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

        public override void Rotate()
        {
            if (points[0].x == points[1].x)
            {
                SetHorizontal();
            }
            else
            {
                SetVertical();
            }
        }

        private void SetVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[i].y + i;
            }
        }

        private void SetHorizontal()
        {
            for ( int i = 0; i < points.Length; i++)
            {
                points[i].y = points[0].y;
                points[i].x = points[i].x + i;
            }
        }
    }
}
