using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertLine :Figure
    {
       

        public VertLine(int x, int yTop,int yBottom, char sym)
        {
            pList = new List<Point>();
            for (int y=yTop; y<=yBottom;y++)
            {
                pList.Add(new Point(x, y, sym));
            }

        }

       

    }
}
