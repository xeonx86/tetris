using System;
using System.Threading;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Stick stk = new Stick(15, 20, 'q');
            stk.Draw();

            Thread.Sleep(1000);
            stk.Hide();
            stk.Move(MotionCommand.Down);
            stk.Draw();

            Thread.Sleep(1000);
            stk.Hide();
            stk.Move(MotionCommand.Down);
            stk.Draw();

            Thread.Sleep(1000);
            stk.Hide();
            stk.Rotate();
            stk.Draw();

            Thread.Sleep(1000);
            stk.Hide();
            stk.Rotate();
            stk.Draw();

            Console.ReadKey();
        
        }


    }
}
