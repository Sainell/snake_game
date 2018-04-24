using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {

            Point p1 = new Point(1, 3,'*');           
            //p1.Draw();

            Point p2 = new Point(4,5,'#');
            //   p2.Draw();

            //List<char> charList = new List<char>();
            //charList.Add('+');
            //charList.Add('-');
            //charList.Add('=');

            //List<Point> pointList = new List<Point>();
            //pointList.Add(p1);
            //pointList.Add(p2);
            //pointList.Add(new Point(5, 5, '&'));

            //foreach (Point a in pointList)
            //{
            //    a.Draw();
            //}
           HorizLine Hline = new HorizLine(0, 79, 0, '*');
            Hline.Draw();
            VertLine Vline = new VertLine(0, 0, 24, '*');
            Vline.Draw();
            Console.ReadLine();

        }

       
    }
}
