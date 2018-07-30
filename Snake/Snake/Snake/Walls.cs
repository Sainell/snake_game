using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls : Figure
    {
        int mapWidth;
        int mapHeight;
        char sym;
        

        public Walls(int mapWidth, int mapHeight, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sym = sym;


            pList = new List<Point>();
            for (int i =  0; i < mapWidth; i++)
            {
               pList.Add(new Point(i, 0, this.sym));
               pList.Add(new Point(i, mapHeight-1, this.sym));
            }
         
            for(int i = 0; i < mapHeight; i++)
            {
                pList.Add(new Point(0, i, this.sym));
               pList.Add(new Point(mapWidth-1, i, this.sym));
            }
        }

        
       
      
    }
}
