using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class ShowTable
    {
       

        public void Show(int[,] Sfild)
        {

            int[,] fild = Sfild;
            for (int i = 0; i < fild.GetLength(0); i++)
            {
                
                for (int j = 0; j < fild.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i*3, j*3);
                    Console.Write(fild[i, j]+"\t");
                    
                }
            }

           
        }
        public void ShowWay(int[,] Sfild, int x, int y)
        {

            int[,] fild = Sfild;
            
          //  for (int i = 0; i < fild.GetLength(0); i++)
          //  {

            //    for (int j = 0; j < fild.GetLength(1); j++)
            //    {
                   // if (i == x && j == y)
                  //  {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(x * 3, y * 3);
                        Console.Write(fild[x, y] );
                        Console.ResetColor();
                 //   }
              //  }
          //  }


        }
    }
}
