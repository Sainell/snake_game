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
            Walls walls = new Walls(60, 25, '*');
            walls.Draw();
            // змея
            Point start = new Point(4, 5, '☼');
            Snake snake = new Snake(start, 10, Direction.RIGHT);
            snake.Draw();
            //очки 
            Snake_Interface score = new Snake_Interface(62, 2, snake.LastDirection );
            score.ShowScore();
           
            //еда
            FoodCreator foodcreator = new FoodCreator(60, 25, '$');
            Point food = foodcreator.CreateFood(snake);
            food.Draw();
            //
            SearchPath sPath = new SearchPath(60,25);

            while (true)
            {
                

                // sPath.Show();

                if (snake.Eat(food))
                {

                    food = foodcreator.CreateFood(snake);
                    food.Draw();
                    score.ScorePlus();
                    score.ShowScore();

                    snake.Draw();

                }
                sPath.Search(snake.pList.Last(), food, snake);
                if (snake.IsHit(walls) || snake.IsHitTail())
                {
                    
                    score.Health();
                    score.ShowScore();
                    snake.Clear();               
                    snake = new Snake(start, 10, Direction.RIGHT);
                    

                    if (score.health == 0)
                    {
                        

                        Console.SetCursorPosition(25, 10);
                        Console.WriteLine("GAME OVER");
                        Thread.Sleep(Timeout.Infinite);

                    }
                    Thread.Sleep(500);
                }
                
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
               // snake.Move();
                sPath.ClearPath();
                
               snake.AutoMove(sPath.path.Last());
                snake.Draw();
                food.Draw();





            }
           
        }

       
    }
}
