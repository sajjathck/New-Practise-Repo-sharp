using System.Collections;

namespace Assignment_Collections
{
    internal class Class4
    {
        static void Main()
        {
            Console.WriteLine("enter the name of the student");
            ArrayList array = new ArrayList();
            array.Add("Id:1,Name:Sajjad");
            array.Add("Id:2,Name: Faris");
            //display
            Console.WriteLine("Student's Details :");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
