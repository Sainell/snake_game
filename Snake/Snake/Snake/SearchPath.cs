using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SearchPath
    {
        int mapWidth;
        int mapHeight;
        Point start = new Point();
        Point finish = new Point();
        int step;
        bool finishFlag;
     public   int[,] field;
      public  List<Point> path = new List<Point>();


        public SearchPath(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth - 1;
            this.mapHeight = mapHeight - 1;

        }
        public void Search(Point _start, Point _finish, Figure _snake)
        {

            start = _start;
            finish.x = _finish.x;
            finish.y = _finish.y;
            field = new int[mapWidth, mapHeight];
            step = 0;
            finishFlag = false;
            path.Clear();
            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = -1;
                }
            foreach (Point p in _snake.pList)
            {
                field[p.x, p.y] = -2;
            }
            field[start.x, start.y] = step;
            
            do
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {

                        if (field[i, j] == step)
                        {
                            if (i != field.GetLength(0) - 1)
                            {
                                if (field[i + 1, j] == -1)
                                {
                                    field[i + 1, j] = step + 1;
                                    //start.x = start.x + 1;
                                }
                                if (i + 1 == finish.x && j == finish.y)
                                {
                                    finishFlag = true;



                                }
                            }



                            if (j != field.GetLength(1) - 1)
                            {
                                if (field[i, j + 1] == -1)
                                {
                                    field[i, j + 1] = step + 1;
                                    //  start.y = start.y + 1;
                                }
                                if (i == finish.x && j + 1 == finish.y)
                                {
                                    finishFlag = true;

                                }
                            }



                            if (i != 0)
                            {
                                if (field[i - 1, j] == -1)
                                {
                                    field[i - 1, j] = step + 1;
                                    //  start.x = start.x - 1;
                                }
                                if (i - 1 == finish.x && j == finish.y)
                                {
                                    finishFlag = true;


                                }
                            }



                            if (j != 0)
                            {
                                if (field[i, j - 1] == -1)
                                {
                                    field[i, j - 1] = step + 1;
                                    //  start.y = start.y - 1;
                                }
                                if (i == finish.x && j - 1 == finish.y)
                                {
                                    finishFlag = true;


                                }
                            }

                        }



                    }

                }
                step++;

            } while (step < field.GetLength(0) * field.GetLength(1) && finishFlag != true);


            do
            {

                step--;
                if (finishFlag == true && step >= 0)

                {


                    if (finish.x != field.GetLongLength(0) - 1)
                    {
                        if (field[finish.x + 1, finish.y] == step)
                        { finish.x = finish.x + 1; }
                    }

                    if (finish.y != field.GetLength(1) - 1)
                    {
                        if (field[finish.x, finish.y + 1] == step)
                        { finish.y = finish.y + 1; }
                    }
                    if (finish.x != 0)
                    {
                        if (field[finish.x - 1, finish.y] == step)
                        { finish.x = finish.x - 1; }
                    }
                    if (finish.y != 0)
                    {
                        if (field[finish.x, finish.y - 1] == step)
                        { finish.y = finish.y - 1; }
                    }



                }
                if (step != 0) ShowPath();




            } while (field[finish.x, finish.y] != 0);// while (field[finish.x, finish.y] != field[start.x,start.y]);
            finishFlag = false;
        }

        public void Show()
        {


            for (int i = 0; i < field.GetLength(0); i++)
            {

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(field[i, j] + "\t");

                }
            }


        }
        public Point ShowPath()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(finish.x, finish.y);
            path.Add(new Point(finish.x, finish.y,'.'));
            Console.Write(".");
            // Console.Write(field[finish.x,finish.y]);
            Console.ResetColor();
            return path.Last();
        }
        public void ClearPath()
        {
            foreach(Point p in path)
            { p.Clear(); }
        }
    }
}
