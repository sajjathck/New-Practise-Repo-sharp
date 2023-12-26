using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class MethodOverLoading
    {
        static void add(int a, int b)
        {
            int c=a+b;
            Console.WriteLine(c);
        }
        static void add(int a, int b,int c )
        {
            int d = a + b + c;
            Console.WriteLine(d);
        }
        static void add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }
        public static void Main()
        {
            add(88,1);
            add(32,3,20);
            add(1.8,8.6);

        }
    }
}
