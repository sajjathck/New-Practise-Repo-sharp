using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo3
    {
        public int sum(int[] a) 
        {
            int result=0;
            foreach (int i in a)
            {
                result += i;
            }
            return result; 
        }
        public string[] Flowers()
        {
            string[] flowers = { "Lilly","Tulip","Jasmine","Rose" };
            return flowers;
        }

        public int sumPara(params int[] a)
        {
            int result = 0;
            foreach (int i in a)
            {  result += i; }
            return result;
        }
        public static void Main(string[] args)
        {
            Demo3 demo = new Demo3();
            demo.Flowers();
            int[] arry = {1,5,54,6,5,23,85,2,3,5,88 }; 
            int result=demo.sum(arry);
            Console.WriteLine(result);
            result = demo.sumPara(1,98,526,55,32,76,635,99);
            Console.WriteLine(result);
        }
    }
}
