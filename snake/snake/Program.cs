using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.SetBufferSize(80,25);
            // рамочка

            HorizontalLine UpLine = new HorizontalLine(0,78,0,'+'); UpLine.Drow();
            HorizontalLine DownLine = new HorizontalLine(0, 78, 23, '+'); DownLine.Drow();
            VerticalLine LeftLine = new VerticalLine(0,23, 0, '+'); LeftLine.Drow();
            VerticalLine RightLine = new VerticalLine(0, 23, 78, '+'); RightLine.Drow();                              

            Point p = new Point(4,5,'*');
            p.Draw();
            Console.ReadLine();

        }
       
    }
}
