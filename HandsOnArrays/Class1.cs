using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Class1
    {
        static void Main()
        {
            bool flag=false;
            string[] students = new string[]
            { 
                "Sajjad","Amal","Bince","JisMon","Faris"
            };
            
            Console.WriteLine("Enter A student Name To be Searched");
            string? name = Convert.ToString(Console.ReadLine());
            //foreach (var student in students)
            //{
            //    if(student==name)
            //    {
            //        flag = true;
            //        break;
            //    }
            //}
            Array.Sort(students);
            Console.WriteLine("Selected Students\n");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            if (Array.BinarySearch(students, name) >= 0)
            {
                flag = true;
                Console.WriteLine(Array.BinarySearch(students, name));
            }
            if (flag)
            {
                Console.WriteLine($"{name} is Selected");
            }
            else
            {
                Console.WriteLine($"{name} is Not Selected");
            }
        }

    }
}
