using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Direction LastDirection = Direction.RIGHT;

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {

                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);

            }

        }

        internal void Move()
        {

            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        internal void AutoMove(Point point)
        {
            
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = point;
            head.sym ='☼';
            pList.Add(head);
            tail.Clear();
            head.Draw();

        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {

            if (key == ConsoleKey.LeftArrow && LastDirection != Direction.RIGHT)
            
                direction = Direction.LEFT;
                LastDirection = direction;
                           
            if (key == ConsoleKey.RightArrow && LastDirection != Direction.LEFT)
                direction = Direction.RIGHT;
                LastDirection = direction;

            if (key == ConsoleKey.UpArrow && LastDirection != Direction.DOWN)
                direction = Direction.UP;
                LastDirection = direction;

            if (key == ConsoleKey.DownArrow && LastDirection != Direction.UP)
                direction = Direction.DOWN;
                LastDirection = direction;
        }
        public bool Eat(Point food)
        {
            Point head = pList.Last();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                food.Draw();
                return true;
            }
            else return false;
        }
        public bool IsHit(Figure figure)
        {
            Point head = GetNextPoint();

            foreach (Point p in figure.pList)
            {
                if (head.isHit(p))
                {
                    return true;
                }
                
            }
            return false;
        }
        public bool IsHitTail()
        {
            Point head = pList.Last();
            for (int i=0; i<pList.Count-2; i++)
            {
                if (head.isHit(pList[i]))
                return true;
            }
            return false;
        }
        
       
    }
}
