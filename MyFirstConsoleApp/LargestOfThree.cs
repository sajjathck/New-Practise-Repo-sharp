using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class LargestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine($"{num1} Is The Largest");
                }
                else
                {
                    Console.WriteLine($"{num3} Is The Largest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num2} Is The Largest");
                }
                else
                {
                    Console.WriteLine($"{num3} Is The Largest");
                }
            }
        }
    }
}
