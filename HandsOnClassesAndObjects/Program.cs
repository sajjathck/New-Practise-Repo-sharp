namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 65;
            s1.name = "Amal";
            s1.gender = 'M';
            s1.age = 18;
            s1.Display();
            Student s2 = new Student();
            s2.id = 45;
            s2.name = "Faris";
            s2.gender = 'F';
            s2.age = 13;
            s2.Display();

            Student s3 = new Student()
            {
                id = 21,
                name = "Sajjad",
                age=25,
                gender='M'
            };
            s3.Display();
            //Student s4 = null;
            //s4.name = "sha";
            //s4.id = 24;
            //s4.gender = 'm';
            //s4.age = 55;

            Student[] students = new Student[3];

            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach (Student student in students)
            {
                Console.WriteLine("From Array");
                student.Display();
            }
        }
    }
}
