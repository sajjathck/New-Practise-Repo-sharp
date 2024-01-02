using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collections
{
    internal class Class2
    {
        static void Main()
        {
            Console.WriteLine("SortedDictionary of Employee Codes and Names");

            SortedDictionary<int, string> employeeData = new SortedDictionary<int, string>
                {
                    { 104, "John Doe" },
                    { 102, "Jane Smith" },
                    { 106, "Bob Johnson" },
                    { 101, "Alice Williams" },
                };
            Console.WriteLine("Employee Data in Sorted Order:");

            foreach (var emp in employeeData)
            {
                Console.WriteLine($"Employee Code: {emp.Key}, Employee Name: {emp.Value}");
            }

            Console.ReadLine();
        }
    }
}
