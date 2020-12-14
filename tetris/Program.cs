using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] figure = new Figure[2];
            figure[0] = new squreDraw(3, 3, '*');
            figure[1] = new Stick(6, 6, '*');

            foreach (Figure fg in figure)
                fg.Draw();


            Console.ReadKey();
        }


    }
}
