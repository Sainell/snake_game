using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program
    {
        
        static void Main()
        {
            
            bool finishFlag = false;
            Point finish = new Point();
            finish.x = 0;
            finish.y = 0;
            
            ShowTable sw = new ShowTable();
            int[,] fild = new int[10, 10];
            for (int i = 0; i < fild.GetLength(0); i++)
            {
                
                for (int j = 0; j < fild.GetLength(1); j++)
                {
                    // fild[i, j] = new Point(i, j, '*');
                    fild[i, j] = -1;
                    sw.Show(fild);

                }
            }
            
            int step = 0;
            fild[0, 0] = step;
            fild[1, 1] = -2;
            fild[2, 1] = -2;
            fild[3, 1] = -2;
            fild[4, 1] = -2;
            fild[5, 1] = -2;
            fild[5, 2] = -2;
            fild[5, 3] = -2;
            fild[5, 4] = -2;
            fild[5, 5] = -2;
            fild[5, 6] = -2;
            fild[5, 7] = -2;
            fild[9, 8] = -1;
            fild[8, 9] = -2;
            fild[7, 6] = -2;
            fild[6, 6] = -2;
            fild[5, 6] = -2;
            fild[8, 6] = -2;
            fild[9, 9] = -5;
            sw.Show(fild);
            do
            {

                for (int i = 0; i < fild.GetLength(0); i++)
                    for (int j = 0; j < fild.GetLength(1); j++)
                    {
                        
                            if (fild[i, j] == step)
                        {
                            if (i != fild.GetLength(0) - 1)
                            {
                                if (fild[i + 1, j] == -1)
                                { fild[i + 1, j] = step + 1; sw.Show(fild); }
                                if (fild[i + 1, j] == -5) { finishFlag = true; finish.x = i + 1; finish.y= j; }
                            }


                            if (j != fild.GetLength(1) - 1)
                            {
                                if (fild[i, j + 1] == -1)
                                { fild[i, j + 1] = step + 1; sw.Show(fild); }
                                else if (fild[i, j + 1] == -5) { finishFlag = true; finish.x = i; finish.y = j+1; }
                            }
                            if (i != 0)
                            {
                                if (fild[i - 1, j] == -1)
                                { fild[i - 1, j] = step + 1; sw.Show(fild); }
                                else if (fild[i - 1, j] == -5) { finishFlag = true; finish.x = i - 1; finish.y = j; }
                            }
                            if (j != 0)
                            {
                                if (fild[i, j - 1] == -1)
                                { fild[i, j - 1] = step + 1; sw.Show(fild); }
                                else if (fild[i, j - 1] == -5) { finishFlag = true; finish.x = i; finish.y = j-1; }
                            }

                        }

                    }

                step++;


            } while (step < fild.GetLength(0) * fild.GetLength(1) && finishFlag == false);

            do
            {

                if (finishFlag == true)
                {
                    sw.ShowWay(fild, finish.x, finish.y);

                    if (finish.x != fild.GetLength(0) - 1)
                    {
                        if (fild[finish.x + 1, finish.y] == step - 1)
                        {  finish.x = finish.x - 1; }
                    }
                    if (finish.y != fild.GetLength(1) - 1)
                    {
                        if (fild[finish.x, finish.y + 1] == step - 1)
                        {  finish.y = finish.y + 1; }
                    }
                    if (finish.x != 0)
                    {
                        if (fild[finish.x - 1, finish.y] == step - 1)
                        {  finish.x = finish.x - 1; }
                    }
                    if (finish.y != 0)
                    {
                        if (fild[finish.x, finish.y - 1] == step - 1)
                        { finish.y = finish.y - 1; }
                    }

                    step--;

                }

            } while (fild[finish.x, finish.y] != 0);




            Console.ReadKey();
        }

    }
}
