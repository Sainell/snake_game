using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {

            Point p1 = new Point(15, 3,'*');           
            p1.Draw();

            


          //рамка
           
            HorizLine Hline = new HorizLine(1, 50, 1, '*');
            HorizLine Hline2 = new HorizLine(1, 50, 20, '*');
            Hline.Draw();
            Hline2.Draw();
            VertLine Vline = new VertLine(1, 1, 20, '*');
            VertLine Vline2 = new VertLine(50, 1, 20, '*');
            Vline.Draw();
            Vline2.Draw();
            
            //**

            Point start = new Point(4, 5, '@');

            Snake snake = new Snake(start, 10, Direction.RIGHT);
            snake.Draw();

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

            



           
        }

       
    }
}
