using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80,25);
            Console.CursorVisible = false;
            // рамочка

            HorizontalLine UpLine = new HorizontalLine(0,78,0,'+'); UpLine.Drow();
            HorizontalLine DownLine = new HorizontalLine(0, 78, 23, '+'); DownLine.Drow();
            VerticalLine LeftLine = new VerticalLine(0,23, 0, '+'); LeftLine.Drow();
            VerticalLine RightLine = new VerticalLine(0, 23, 78, '+'); RightLine.Drow();                              

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
                Thread.Sleep(100);
                snake.Move();
            }
           
          //  Console.ReadLine();

        }
       
    }
}
