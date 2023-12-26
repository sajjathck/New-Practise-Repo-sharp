using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo1
    {
        int count = 0;
        public void Message()
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine(count);
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello "+name);
            count++;
        }
        public void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public static void Main(string[] args)
        {
            Demo1 demo = new Demo1();
            demo.Message();
            demo.Greet("Sajjad");
            demo.Greet("Amal");
            demo.Greet("Obama");
            demo.Greet("Faris");
            demo.Greet("Bince");
            demo.Message();
            demo.add(16,28);
        }
    }
}
