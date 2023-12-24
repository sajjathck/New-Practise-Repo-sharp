using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class DisplayNums
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            var num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            var num2 = int.Parse(Console.ReadLine());
            for (int i = num1+1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
