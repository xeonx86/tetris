using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Figure
    {
       protected Point[] points = new Point[4];


        public void Draw()
        {
            foreach (Point p in points)
                p.Draw();
        }

        public void Move(MotionCommand mc)
        {
            foreach(Point p in points)
            {
                p.Move(mc);
            }
        }

        public void Hide()
        {
            foreach(Point p in points)
            {
                p.Hide();
            }
        }
    }
}
