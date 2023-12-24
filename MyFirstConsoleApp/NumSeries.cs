using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class NumSeries
    {
        static void Main()
        {
            //Write a program to print the series: 0,1,4,9,16,.....625
            for (int i = 0; i <= 625; i++)
            {
                for(int j = 1; j < 625; j=j+2)
                {
                    Console.WriteLine(i);
                    i = i + j;
                    
                }
            }  
        }
    }
}
