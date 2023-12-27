namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] marks = new int[6];
            marks[0] = 81;
            marks[1] = 28;
            marks[2] = 65;
            marks[3] = 91;
            marks[4] = 74;
            marks[5] = 65;
            int total = 0;
            for(int i = 0; i < 6; i++)
            {
               // Console.WriteLine(marks[i]);
                total= total + marks[i];
            }
            Console.WriteLine("total="+total);
            foreach(int i in marks)
            {
                Console.WriteLine(i);
            }
        }
    }
}
