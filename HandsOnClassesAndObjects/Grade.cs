using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Grade
    {
        public static int[] marks;
        public static int total;

        public static int Total()
        {
            int totl = 0;
            foreach (int i in marks)
            {
                totl = i;
            }
            total = totl;
            return total;
        }
        public static void Main()
        {

        }
    }
}
