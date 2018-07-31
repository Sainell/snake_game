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
       public Snake_Interface(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public void ShowScore()
        {
            
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Score: "+ score);
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine("Health: " + health);


        }
        public void ScorePlus()
        {
            score++;
        }
        public void Health()
        {
            health--;
            
        }
    }
}
