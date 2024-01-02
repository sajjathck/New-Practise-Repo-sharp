
namespace Week1CodeChallenge

{

    public class Student

    {

        int id;

        string name;

        char sec;

        byte age;

        string standard;

        public Student()

        {

            this.id = 0;

            this.name = "";

            this.sec = ' ';

            this.age = 0;

            this.standard = " ";

        }

        public Student(Student student)

        {

            this.id = student.id;

            this.name = student.name;

            this.sec = student.sec;

            this.age = student.age;

            this.standard = student.standard;

        }


        public int ID { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public char Sec { get { return sec; } set { sec = value; } }

        public byte Age { get { return age; } set { age = value; } }

        public string Standard { get { return standard; } set { standard = value; } }


        public void Display()

        {

            Console.WriteLine();

            Console.WriteLine($"Name:{Name} ");

            Console.WriteLine($"ID:{ID} ");

            Console.WriteLine($"Age:{Age} ");

            Console.WriteLine($"Standard:{Standard} ");

            Console.WriteLine($"Section:{Sec} ");

            Console.WriteLine();

        }


    }

    interface IStudentRepository

    {

        Student GetStudentByID(int id);

        Student[] GetStudentsByAge(byte age);

        Student GetStudentByName(string name);

        Student[] GetStudentsByStandard(string standard);

        Student[] GetStudentsByStandard_Section(string standard, char sec);

        Student[] GetAllStudents();

        void CreateStudent();

        void UpdateStudent();


    }

    public class StudentRepository : IStudentRepository

    {

        Student student1 = new Student();

        Student[] students = new Student[10];

        static int i = 0;

        public void CreateStudent()

        {

            try

            {


                if (i < 10)

                {

                    students[i] = new Student();

                    Console.WriteLine("Enter Student Details.......");

                    Console.Write("Student Name:");

                    students[i].Name = Console.ReadLine();

                    Console.Write("Student ID:");

                    students[i].ID = int.Parse(Console.ReadLine());

                    Console.Write("Age:");

                    students[i].Age = byte.Parse(Console.ReadLine());

                    Console.Write("Standard:");

                    students[i].Standard = Console.ReadLine();

                    Console.Write("Section:");

                    students[i].Sec = char.Parse(Console.ReadLine());

                    i++;

                }

                else

                {

                    Console.WriteLine("Directory Full...");

                }

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

        }

        public Student[] GetAllStudents()

        {

            return students;

        }

        public Student GetStudentByID(int id)

        {

            try

            {

                bool flag = false;

                foreach (Student student in students)

                {

                    if (student != null)

                    {

                        if (student.ID == id)

                        {

                            flag = true;

                            return student;

                        }

                    }


                }

                if (flag == false)

                    Console.WriteLine("\nStudent not found....");

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            return null;


        }

        public Student GetStudentByName(string name)

        {

            try

            {

                bool flag = false;

                foreach (Student student in students)

                {

                    if (student != null)

                    {

                        if (student.Name == name)

                        {

                            flag = true;

                            return student;

                        }

                    }


                }

                if (flag == false)

                    Console.WriteLine("\nStudent not found....");

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            return null;

        }

        public Student[] GetStudentsByStandard(string standard)

        {

            try

            {

                Student[] result = new Student[10];

                int j = 0;

                bool flag = false;

                foreach (Student student in students)

                {

                    if (student != null)

                    {

                        if (student.Standard == standard)

                        {

                            flag = true;

                            result[j] = new Student(student);

                            j++;

                        }

                    }


                }

                if (flag == false)

                {

                    Console.WriteLine("\nStudent not found....");

                    return null;

                }

                else

                    return result;

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            return null;

        }

        public Student[] GetStudentsByStandard_Section(string standard, char sec)

        {

            try

            {


                Student[] result = new Student[10];

                int j = 0;

                bool flag = false;

                foreach (Student student in students)

                {

                    if (student != null)

                    {

                        if (student.Standard == standard && student.Sec == sec)

                        {

                            flag = true;

                            result[j] = new Student(student);

                            j++;

                        }

                    }


                }

                if (flag == false)

                {

                    Console.WriteLine("\nStudent not found....");

                    return null;

                }

                else

                    return result;

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            return null;

        }

        public void UpdateStudent()

        {

            try

            {

                Console.WriteLine("What do you wish to Update:\n1.Name\n2.Age\nEnter your choice(1/2):");

                int ch = int.Parse(Console.ReadLine());


                switch (ch)

                {

                    case 1:

                        {

                            Console.Write("Enter ID of the Student:");

                            int n = int.Parse(Console.ReadLine());

                            Console.Write("Enter new name of the Student:");

                            string newName = Console.ReadLine();

                            bool flag = false;

                            foreach (Student student in students)

                            {

                                if (student != null)

                                {

                                    if (student.ID == n)

                                    {

                                        flag = true;

                                        student.Name = newName;

                                    }

                                }


                            }

                            if (flag == false)

                                Console.WriteLine("\nStudent not found....");

                            break;

                        }

                    case 2:

                        {

                            Console.Write("Enter ID of the Student:");

                            int n = int.Parse(Console.ReadLine());

                            Console.Write("Enter new age of the Student:");

                            byte newAge = byte.Parse(Console.ReadLine());

                            bool flag = false;

                            foreach (Student student in students)

                            {

                                if (student != null)

                                {

                                    if (student.ID == n)

                                    {

                                        flag = true;

                                        student.Age = newAge;

                                    }

                                }


                            }

                            if (flag == false)

                                Console.WriteLine("\nStudent not found....");

                            break;

                        }

                    default:

                        Console.WriteLine("Invalid Choice!!!");

                        break;

                }

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

        }

        public Student[] GetStudentsByAge(byte age)

        {

            try

            {

                Student[] result = new Student[10];

                int j = 0;

                bool flag = false;

                foreach (Student student in students)

                {

                    if (student != null)

                    {

                        if (student.Age == age)

                        {

                            flag = true;

                            result[j] = new Student(student);

                            j++;

                        }

                    }


                }

                if (flag == false)

                {

                    Console.WriteLine("\nStudent not found....");

                    return null;

                }

                else

                    return result;

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }

            return null;

        }

    }


    internal class Program

    {


        static void Main(string[] args)

        {

            StudentRepository studentRepository = new StudentRepository();

            Student student = new Student();

            Student[] students = new Student[10];

            Console.WriteLine("Student Data Management...");

            while (true)

            {

                Console.WriteLine("1.Create Student");

                Console.WriteLine("2.Update Student");

                Console.WriteLine("3.Display Student");

                Console.WriteLine("4.Exit");

                Console.Write("Enter your choice(1/2/3):");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        studentRepository.CreateStudent();

                        break;

                    case 2:

                        studentRepository.UpdateStudent();

                        break;

                    case 3:

                        Console.WriteLine("How do you want to search??");

                        Console.WriteLine("1.By name");

                        Console.WriteLine("2.By ID");

                        Console.WriteLine("3.By standard");

                        Console.WriteLine("4.By standard and section");

                        Console.WriteLine("5.By age");

                        Console.WriteLine("6.Display-All");

                        int ch2 = int.Parse(Console.ReadLine());

                        switch (ch2)

                        {

                            case 1:

                                Console.Write("Enter name of Student: ");

                                string nn = Console.ReadLine();

                                student = studentRepository.GetStudentByName(nn);

                                if (student != null)

                                {

                                    student.Display();

                                }

                                break;

                            case 2:

                                Console.Write("Enter ID of Student: ");

                                int iid = int.Parse(Console.ReadLine());

                                student = studentRepository.GetStudentByID(iid);

                                if (student != null)

                                {

                                    student.Display();

                                }

                                break;

                            case 3:

                                Console.Write("Enter standard:");

                                string sstd = Console.ReadLine();

                                students = studentRepository.GetStudentsByStandard(sstd);

                                foreach (Student s in students)

                                {


                                    if (s != null)

                                    {

                                        s.Display();

                                    }

                                }

                                break;

                            case 4:

                                Console.Write("Enter standard and section:\n");

                                string sstd_ = Console.ReadLine();

                                char secc = char.Parse(Console.ReadLine());

                                students = studentRepository.GetStudentsByStandard_Section(sstd_, secc);

                                foreach (Student s in students)

                                {


                                    if (s != null)

                                    {

                                        s.Display();

                                    }

                                }

                                break;

                            case 5:

                                Console.Write("Enter Age:");

                                byte aage = byte.Parse(Console.ReadLine());

                                students = studentRepository.GetStudentsByAge(aage);

                                if (students != null)

                                {


                                    foreach (Student s in students)

                                    {


                                        if (s != null)

                                        {

                                            s.Display();

                                        }

                                    }

                                }

                                else

                                {

                                    Console.WriteLine("No result found");

                                }

                                break;

                            case 6:

                                students = studentRepository.GetAllStudents();

                                foreach (Student s in students)

                                {


                                    if (s != null)

                                    {

                                        s.Display();

                                    }

                                }

                                break;


                        }




                        break;

                    case 4:

                        Environment.Exit(0);

                        break;

                }

            }


        }

    }

}