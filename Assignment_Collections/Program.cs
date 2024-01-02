namespace Assignment_Collections
{/*3. Accept 10 numbers and sort the data in ascending order and display it.
            4. Write an Arraylist that will hold the names of all students and display them in descending order.
            5. Write an executable program in C# that will hold the employee code and employee names available in 
                an Organization using Collections.When the data is displayed it should be in a sorted manner.Choose an 
                appropiate type of Collection.
            6. Create a class called BookStore with fields Bookid and Bookname.Accept and display the details using 
                HashTable.
            7. Create a class with name student and store all the student details in an ArrayList and Display the 
                Details.
            8. Employee details name and designation is entered by the user in random order. It is desired to 
               maintain a list such that all the employees with the same designation must be kept together. Also, the 
               list must have Program Managers first, then Project Manager, Team Lead, Senior Programmer and 
               Junior Programmer in that order. Display the list after all entry is done*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            Array.Sort(numbers);

            Console.WriteLine("\nSorted Numbers in Ascending Order:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}