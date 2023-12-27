using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    
    
        class II {
            public int x;
            public int y;
            public II(int x,int y) {
                this.x = x;
                this.y = y;
            }
        }
    class JJ : II
    {
        public JJ():base(2,3)//base keyword is used to call base class paramemter Constuctor
        {

        }
        public JJ(int k,int l):base(k,l)
        {

        }
        public void f()
        {
            Console.WriteLine($"x:{x} Y:{y}");
        }
    }
    internal class Class1
    {
        static void Main()
        {
            JJ obj = new JJ();
            obj.f();
            JJ obj2 = new JJ(85, 96);
            obj2.f();
        }
    }
}
