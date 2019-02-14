using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake_Interface
    {
        int score;
       public int health=3;
        int x;
        int y;
        Direction dir;
       public Snake_Interface(int x, int y,Direction dir)
        {
            this.x = x;
            this.y = y;
            this.dir = dir;

        }
        public void ShowScore()
        {
            
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Score: "+ score);
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine("Health: " + health);
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("dir: " + dir);


        }
        public void ScorePlus()
        {
            score++;
            
        }
        public void Health()
        {
            health--;
            
        }
        //public void ChangeDir(Direction dir)
        //{
        //    this.dir = dir;
        //    Console.SetCursorPosition(x, y + 4);
        //    Console.WriteLine("direction " + dir);
        //}
    }
}
