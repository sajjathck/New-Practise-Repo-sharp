using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Staff
    {
        public int staffId;
        public string staffName;

        public static string schoolName;
        public static string branchName;

        public const string city = "Calicut";

        public string Display()
        {
            return $"\nId : {staffId}\n Name : {staffName}\n School : {schoolName}\n Branch : {branchName}\n City : {city}\n";
        }
        static void Main()
        {
            Staff.schoolName = "NNMHSS";
            Staff.branchName = "Farook College";

            Staff s1 = new Staff() {staffId=585,staffName="Jasim" };
            Staff s2 = new Staff() { staffId = 556, staffName = "Smitha" };
            Staff s3 = new Staff() {staffId = 591, staffName = "Khader" };
            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());
            Console.WriteLine(s3.Display());
        }
    }
}
