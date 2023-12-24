using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Multiplication
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //10. Write a program in C# to find the multiplication table of the given number till 20.
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i} x {num1} : "+i* num1);
            }
        }
    }
}
