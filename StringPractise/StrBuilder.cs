using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractise
{
    internal class StrBuilder
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Good Morning");
            Console.WriteLine(sb);
            sb.Replace("Mo", "Lea");
            Console.WriteLine(sb);
            sb.Remove(5,9);
            Console.WriteLine(sb);
            sb.Insert(6,'D'); 
            Console.WriteLine(sb.MaxCapacity);

            string s1 = "David";
            string s2 = "David";
            if (s1.Equals(s2)) //Equals method return true when strings are equal
            {
                Console.WriteLine("strings are equal");
            }
            else
                Console.WriteLine("strings are not equal");
        }
    }
}
