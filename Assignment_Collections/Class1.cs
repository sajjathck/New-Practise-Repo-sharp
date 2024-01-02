using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collections
{
    internal class Class1
    {
        static void Main()
        {
            Console.WriteLine("enter the  names of the student :");
            Console.WriteLine();
            ArrayList array = new ArrayList();
            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"Name: ");
                string? name = Console.ReadLine();
                array.Add(name);
            }

            array.Sort();
            array.Reverse();    
            Console.WriteLine("Sorted array :");
            foreach (var name in array)
            {
                Console.WriteLine(name);
            }
        }
    }
}
