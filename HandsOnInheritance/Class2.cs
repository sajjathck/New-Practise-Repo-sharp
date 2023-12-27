using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Method Hiding
    internal class Class2
    {
        static void Main()
        {
            Staff s = new Staff(45,"Amal");
            s.Display();
            Principal p=new Principal(78,"Faris","Low");
            p.Display();
        }
    }
    public class Staff
    {
        public int staffId;
        public string staffName;
        public Staff(int staffId,string staffName) {
            this.staffId = staffId;
            this.staffName = staffName;
        }
        public void Display()
        {
            Console.WriteLine($"ID={staffId} Name={staffName}");
        }
    }
    class Principal : Staff
    {
        public string Level;

        public Principal(int staffId,string staffName,string level):base(staffId,staffName)//parameters from base class
        {
            this.Level = level;
        }
        
        new public void Display()//here new Keyword is used
        {
            Console.WriteLine($"ID={staffId} Name={staffName} Level:{Level}");
        }
    }
}
