﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
   public class Point
    {

      public  int x;
    public    int y;
        char sym = '*';
        public Point()
        {
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y+1;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
                
        } 
    }
}
