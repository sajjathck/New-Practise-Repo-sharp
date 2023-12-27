using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Class1
    {
        static void Main()
        {
            object obj = null;
            int k = 34;
            double db = 87.34;
            decimal dc = 65.98533m;
            //Implicit Conversion
            object o1 = k;
            object o2 = db;
            object o3 = dc;
            object o4 = 65;
            int n=(int)o4;


        }
    }
}
