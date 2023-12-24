using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
