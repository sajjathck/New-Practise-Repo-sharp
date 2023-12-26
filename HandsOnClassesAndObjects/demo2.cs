using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class demo2
    {
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        public double square(double a)
        {
            return a*a;
        }   
        public static void Main(string[] args)
        {
            demo2 demo = new demo2();
            Console.WriteLine(demo.Greet("Sajjad"));
        }
    }
}
