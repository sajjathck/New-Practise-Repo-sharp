using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Factorial
    {
        static void Main()
        {
            //8. Write a program in C# to find the factorial of the given number.
            Console.WriteLine("Enter A Number");
            int num=int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= num; i++)
            {
                    fact = fact * i;              
            }
            Console.WriteLine(fact);
        }
    }
}
