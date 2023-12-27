using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name");
            string employeeName=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee id");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            string designation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Details");
            Console.WriteLine($"Name:{employeeName} Id:{employeeId} Gender:{gender} Designation:{designation} Salary:{salary}");

        }
    }
}
