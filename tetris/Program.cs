using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            squreDraw sq = new squreDraw(3, 3, '*');
            sq.Draw();


            Console.ReadKey();
        }


    }
}
