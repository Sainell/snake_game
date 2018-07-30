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

            //  Point p1 = new Point(15, 3,'$');           
            //  p1.Draw();




            //рамка
            Walls walls = new Walls(50, 20, '=');
            walls.Draw();
          


            //еда
            FoodCreator foodcreator = new FoodCreator(50, 20, '$');
            Point food = foodcreator.CreateFood();
            food.Draw();  

            // змея
            Point start = new Point(4, 5, '☼');
            Snake snake = new Snake(start, 10, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (snake.IsHit(walls) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            



           
        }

       
    }
}
