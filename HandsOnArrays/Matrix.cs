using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Matrix
    {
        static void Main()
        {
            int[,] arry = new int[3,2];
            //3x2 matrix
            arry[0,0] = 45;
            arry[0,1] = 52;
            
            arry[1,0] = 99;
            arry[1,1] = 64;
            
            arry[2,0] = 73;
            arry[2,1] = 28;

            //foreach(int x in arry)
            //{
            //    Console.WriteLine(x);
            //}
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.Write(arry[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
