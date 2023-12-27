namespace Student //assembly
{
    internal class Student 
    {
        static void Main()
        {
            //string studentName = "Amal";
            //string gender = "Male";
            //int age = 25;
            //string schoolName = "Amal Jyothi";
            //int standard = 9;
            //char section = 'B';
            //double totalMarks = 544d;
            //float average = 44.5f;

            //Console.WriteLine("studentName : " + studentName);
            //Console.WriteLine("gender : " + gender);
            //Console.WriteLine("age : " + age);
            //Console.WriteLine("schoolName : " + schoolName);
            //Console.WriteLine("standard : " + standard);
            //Console.WriteLine("section : " + section);
            //Console.WriteLine("totalMarks : " + totalMarks);
            //Console.WriteLine("average : " + average);



            int m = 345;
            short ss=(short)m;
            byte bb = (byte)m;
            long l = 324087456789098975;
            m=(int)l;
            double d = 334.8676;
            m = (int)d;
            decimal dc = 34.5675m;
            int i=(int)dc;
            byte b=(byte)dc;
            short t=(short)dc;
            long g=(long)dc;
            double h=(double)dc;

           // Console.WriteLine("" + h);


            string s = "234";
            int kj=int.Parse(s);
            Console.WriteLine(kj);

            int kl = 3456;
            string s1=kl.ToString();
            Console.WriteLine(s1);
        }
    }
}
