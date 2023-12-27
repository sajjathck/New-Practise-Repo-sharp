namespace ConditionalAndIterativeStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-else Condition
            int m1 = 354, m2 = 90,m3=65;
            Console.WriteLine("enter numbers");
            m1=Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            if (m1>m2) 
            {
                if (m1 > m3)
                {
                    Console.WriteLine($"{m1} is Greater");
                }
                else
                {
                    Console.WriteLine($"{m3} is Greater");
                }
            }
            else {
                if (m2 > m3)
                {
                    Console.WriteLine($"{m2} is Greater");
                }
                else
                {
                    Console.WriteLine($"{m3} is Greater");
                }
            }
        }
    }
}
