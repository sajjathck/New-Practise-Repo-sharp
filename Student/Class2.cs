using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Class2
    {
        static void Main() {
            //Using Convert Class To Convert one datatype to other
            double d = 76.67;
            int k = Convert.ToInt32(d);
            Console.WriteLine(k);
            k = Convert.ToInt32("654");
            Console.WriteLine(k);
            object r0 = "56";
            k = Convert.ToInt32(r0);
            Console.WriteLine(k);
        }
    }
}
